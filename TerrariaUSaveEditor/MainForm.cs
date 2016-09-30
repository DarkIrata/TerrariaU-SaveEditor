using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerrariaUSaveEditor.GameData;

namespace TerrariaUSaveEditor
{
    public partial class MainForm : Form
    {
        private SaveHandler saveHandler = new SaveHandler();

        private TreeNode selectedTreeNode = null;

        public MainForm()
        {
            this.InitializeComponent();
            this.InitializeInventoryTab();
            this.Editor.ChangesSavedEvent += Editor_ChangesSavedEvent;

            this.ControlsEnabled(false);
            foreach (var item in Enum.GetValues(typeof(Difficutly)))
            {
                this.CBoxDifficulty.Items.Add(item);
            }
            
        }

        private void Editor_ChangesSavedEvent(object sender, ItemEditorSavedEventArgs e)
        {
            var node = this.InventoryTree.Nodes[e.InventoryData.SlotType.ToString()].Nodes[e.InventoryData.SlotType.ToString() + e.InventoryData.Slot];
            node.Text = $"[{Prefixes.GetPrefixNameById(e.InventoryData.Prefix)}] {e.InventoryData.Item.Name}";
            node.Tag = e.InventoryData;
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var fileDialog = new OpenFileDialog())
            {
                fileDialog.Filter = "Save files (*.plr)|*.plr";
                fileDialog.Title = "Select Terraria Wii U save file";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.saveHandler.LoadSave(fileDialog.FileName);

                    this.GetSaveDataToControls();
                    this.ControlsEnabled(true);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.GetControlsDataToSave();
            this.saveHandler.SaveSave();
            MessageBox.Show("Saved successfully!");

            this.saveHandler.LoadSave(this.saveHandler.SavePath);
            this.GetSaveDataToControls();
            if (this.selectedTreeNode != null)
            {
                this.Editor.LoadInventoryItem((InventoryData)this.selectedTreeNode.Tag);
            }
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            string error = string.Empty;
            if (!ValidationHelper.IsNameValid(this.TxtName.Text, out error))
            {
                this.SetLabelInfoText(this.lblNameError, error, true);
                return;
            }

            this.SetLabelInfoText(this.lblNameError, "OK", false);
        }
        private void BtnSetGender_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Gender gender = Gender.Male;
            if (btn == BtnFemale)
            {
                gender = Gender.Female;
            }

            this.FlipGenderControls(gender);
            this.saveHandler.SetGender(gender);
        }

        private void PanelColorX_Click(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            Panel panel = (Panel)sender;
            var colorDialog = new ColorDialog();
            colorDialog.FullOpen = true;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                panel.BackColor = colorDialog.Color;
            }
        }
        
        private void InventoryTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag == null)
            {
                return;
            }

            if (this.selectedTreeNode == null)
            {
                this.selectedTreeNode = e.Node;
            }

            this.selectedTreeNode.BackColor = e.Node.BackColor;
            this.selectedTreeNode = e.Node;
            this.selectedTreeNode.BackColor = Color.FromArgb(255, 106, 106);

            var invData = (InventoryData)e.Node.Tag;
            this.Editor.LoadInventoryItem(invData);
        }

        private void GetSaveDataToControls()
        {
            // Char
            this.TxtName.Text = this.saveHandler.GetPlayerName();
            this.FlipGenderControls(this.saveHandler.GetGender());
            this.CBoxDifficulty.SelectedIndex = (int)this.saveHandler.GetDifficutly();

            List<Color> charColors = this.saveHandler.GetColors();
            if (charColors.Count != 7)
            {
                throw new IndexOutOfRangeException("Character colors could not be determined");
            }
            this.PanelColorHair.BackColor = charColors[0];
            this.PanelColorBody.BackColor = charColors[1];
            this.PanelColorEye.BackColor = charColors[2];
            this.PanelColorUnderShirt.BackColor = charColors[3];
            this.PanelColorShirt.BackColor = charColors[4];
            this.PanelColorPants.BackColor = charColors[5];
            this.PanelColorShoes.BackColor = charColors[6];

            // Inv
            var inventory = this.saveHandler.GetInventory();
            foreach (var item in inventory)
            {
                this.FillNodeData(item.Key.ToString(), item.Value);
            }
        }

        private void GetControlsDataToSave()
        {
            // Char
            if (ValidationHelper.IsNameValid(this.TxtName.Text))
            {
                this.saveHandler.SetPlayerName(this.TxtName.Text);
            }

            this.saveHandler.SetDifficutly((Difficutly)this.CBoxDifficulty.SelectedIndex);

            List<Color> charColors = new List<Color>();
            charColors.Add(this.PanelColorHair.BackColor);
            charColors.Add(this.PanelColorBody.BackColor);
            charColors.Add(this.PanelColorEye.BackColor);
            charColors.Add(this.PanelColorUnderShirt.BackColor);
            charColors.Add(this.PanelColorShirt.BackColor);
            charColors.Add(this.PanelColorPants.BackColor);
            charColors.Add(this.PanelColorShoes.BackColor);
            this.saveHandler.SetColors(charColors);

            // Inv
            Dictionary<SlotType, List<InventoryData>> inventory = new Dictionary<SlotType, List<InventoryData>>();
            foreach (TreeNode mainNode in this.InventoryTree.Nodes)
            {
                List<InventoryData> invDataList = new List<InventoryData>();
                foreach (TreeNode itemNode in mainNode.Nodes)
                {
                    if (itemNode.Tag is InventoryData)
                    {
                        invDataList.Add((InventoryData)itemNode.Tag);
                    }
                }
                inventory.Add((SlotType)Enum.Parse(typeof(SlotType), mainNode.Name), invDataList);
            }
            this.saveHandler.SetInventory(inventory);
        }

        private void ControlsEnabled(bool enabled)
        {
            this.groupBox1.Enabled = enabled;
            this.groupBox2.Enabled = enabled;
            this.InvTab.Enabled = enabled;
            this.saveToolStripMenuItem.Enabled = enabled;
        }

        private void FlipGenderControls(Gender gender)
        {
            this.BtnMale.Enabled = true;
            if (gender == Gender.Male)
            {
                this.BtnMale.Enabled = false;
            }
            this.BtnFemale.Enabled = !this.BtnMale.Enabled;
        }

        private void SetLabelInfoText(Label label, string text, bool isError)
        {
            label.Text = text;
            label.ForeColor = isError ? Color.DarkRed : Color.DarkGreen;
        }

        private void InitializeInventoryTab()
        {
            this.InitialTreeNode(SlotType.Bar.ToString(), 10);
            this.InitialTreeNode(SlotType.Inv.ToString(), 30);
            this.InitialTreeNode(SlotType.Ammo.ToString(), 4);
            this.InitialTreeNode(SlotType.Money.ToString(), 4);
        }

        private void InitialTreeNode(string nodeName, int amountSubNodes)
        {
            var node = this.InventoryTree.Nodes[nodeName];
            for (int i = 0; i < amountSubNodes; i++)
            {
                var subNode = new TreeNode("Empty");
                subNode.Name = nodeName + i;
                subNode.Tag = new InventoryData(Convert.ToUInt16(i), (SlotType)Enum.Parse(typeof(SlotType), nodeName));
                node.Nodes.Add(subNode);
            }
        }
        
        private void FillNodeData(string nodeName, List<InventoryData> data)
        {
            var nodes = this.InventoryTree.Nodes[nodeName].Nodes;
            foreach (var invData in data)
            {
                nodes[nodeName + invData.Slot].Text = $"[{Prefixes.GetPrefixNameById(invData.Prefix)}] {invData.Item.Name}";
                nodes[nodeName + invData.Slot].Tag = invData;
            }
        }
    }
}
