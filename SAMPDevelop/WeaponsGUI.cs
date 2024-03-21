using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAMPDevelop
{
    public partial class WeaponsGUI : Form
    {
        public WeaponsGUI()
        {
            InitializeComponent();
            FillWeaponsGUI();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void FillWeaponsGUI()
        {
            dataGridView1.Rows.Add("0", "Hand", "", "Fist", "0", "-", "-");
            dataGridView1.Rows.Add("0", "Hand", "Brassknuckle.png", "Brassknuckle", "1", "331", "-");
            dataGridView1.Rows.Add("1", "Melee", "Golfclub.png", "Golfclub", "2", "333", "-");
            dataGridView1.Rows.Add("1", "Melee", "Nightstick.png", "Nightstick", "3", "334", "-");
            dataGridView1.Rows.Add("1", "Melee", "Knife.png", "Knife", "4", "335", "-");
            dataGridView1.Rows.Add("1", "Melee", "Bat.png", "Bat", "5", "336", "-");
            dataGridView1.Rows.Add("1", "Melee", "Shovel.png", "Shovel", "6", "337", "-");
            dataGridView1.Rows.Add("1", "Melee", "Poolcue.png", "Poolstick", "7", "338", "-");
            dataGridView1.Rows.Add("1", "Melee", "Katana.png", "Katana", "8", "339", "-");
            dataGridView1.Rows.Add("1", "Melee", "Saw.png", "Chainsaw", "9", "341", "-");
            dataGridView1.Rows.Add("2", "Handguns", "Colt45.png", "Colt_45", "22", "346", "17 (34)");
            dataGridView1.Rows.Add("2", "Handguns", "Silenced.png", "Silenced", "23", "347", "17");
            dataGridView1.Rows.Add("2", "Handguns", "Deagle.png", "Deagle", "24", "348", "7");
            dataGridView1.Rows.Add("3", "Shotguns", "Shotgun.png", "Shotgun", "25", "349", "1");
            dataGridView1.Rows.Add("3", "Shotguns", "Sawnoff.png", "Sawed_off", "26", "350", "2 (4)");
            dataGridView1.Rows.Add("3", "Shotguns", "Spas12.png", "Combat_Shotgun", "27", "351", "7");
            dataGridView1.Rows.Add("4", "Sub-Machine Guns", "Mac10.png", "Uzi", "28", "352", "50 (100)");
            dataGridView1.Rows.Add("4", "Sub-Machine Guns", "Mp5.png", "MP5", "29", "353", "30");
            dataGridView1.Rows.Add("4", "Sub-Machine Guns", "Tec9.png", "Tec_9", "32", "372", "50 (100)");
            dataGridView1.Rows.Add("5", "Assault Rifles", "Ak47.png", "AK_47", "30", "355", "30");
            dataGridView1.Rows.Add("5", "Assault Rifles", "M4.png", "M4", "31", "356", "50");
            dataGridView1.Rows.Add("6", "Rifles", "Rifle.png", "Rifle", "33", "357", "1");
            dataGridView1.Rows.Add("6", "Rifles", "Sniper.png", "Sniper", "34", "358", "1");
            dataGridView1.Rows.Add("7", "Heavy Weapons", "Rocketla.png", "Rocket_Launcher", "35", "359", "1");
            dataGridView1.Rows.Add("7", "Heavy Weapons", "Heatseek.png", "Rocket_Launcher_HS", "36", "360", "1");
            dataGridView1.Rows.Add("7", "Heavy Weapons", "Flame.png", "Flamethrower", "37", "361", "50");
            dataGridView1.Rows.Add("7", "Heavy Weapons", "Minigun.png", "Minigun", "38", "362", "500");
            dataGridView1.Rows.Add("8", "Projectiles", "Grenade.png", "Grenade", "16", "342", "1");
            dataGridView1.Rows.Add("8", "Projectiles", "Teargas.png", "Teargas", "17", "343", "1");
            dataGridView1.Rows.Add("8", "Projectiles", "Molotov.png", "Molotov", "18", "344", "1");
            dataGridView1.Rows.Add("8", "Projectiles", "Satchel.png", "Satchel", "39", "363", "1");
            dataGridView1.Rows.Add("9", "Special 1", "Spraycan.png", "Spraycan", "41", "365", "500");
            dataGridView1.Rows.Add("9", "Special 1", "Fire ex.png", "Fire_Extinguisher", "42", "366", "500");
            dataGridView1.Rows.Add("9", "Special 1", "Camera.png", "Camera", "43", "367", "36");
            dataGridView1.Rows.Add("10", "Gifts", "Dildo1.png", "Dildo1", "10", "321", "-");
            dataGridView1.Rows.Add("10", "Gifts", "Dildo2.png", "Dildo2", "11", "322", "-");
            dataGridView1.Rows.Add("10", "Gifts", "Vibe1.png", "Vibrator", "12", "323", "-");
            dataGridView1.Rows.Add("10", "Gifts", "Flowers.png", "Flower", "14", "325", "-");
            dataGridView1.Rows.Add("10", "Gifts", "Cane.png", "Cane", "15", "326", "-");
            dataGridView1.Rows.Add("11", "Special 2", "Irgoggle.png", "Nightvision", "44", "368", "-");
            dataGridView1.Rows.Add("11", "Special 2", "Irgoggle.png", "Infrared", "45", "369", "-");
            dataGridView1.Rows.Add("11", "Special 2", "Paracute.png", "Parachute", "46", "371", "-");
            dataGridView1.Rows.Add("12", "Satchel Detonator", "Bomb.png", "Bomb", "40", "364", "-");

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    string imageName = row.Cells[3].Value.ToString();
                    Image originalImage = (Image)Properties.Resources.ResourceManager.GetObject(imageName);

                    if (originalImage != null)
                    {
                        int rowHeight = row.Height;
                        float scale = (float)rowHeight / originalImage.Height;

                        Image resizedImage = new Bitmap(originalImage, new Size((int)(originalImage.Width * scale), rowHeight));
                        DataGridViewImageCell imageCell = new DataGridViewImageCell();
                        imageCell.Value = resizedImage;
                        row.Cells[2] = imageCell; 
                    }
                    else
                    {
                        MessageBox.Show($"Image '{imageName}' not found in the resources.");
                    }
                }
            }
        }
    }
}
