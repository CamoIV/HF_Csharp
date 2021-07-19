using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonProjectVersion2
{
    public partial class TheQuest : Form
    {

        private Game game;
        private Random random = new Random();

        public TheQuest()
        {
            InitializeComponent();
        }

        private void TheQuest_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(78, 57, 420, 155));
            game.NewLevel(random);
            UpdateCharacters();
        }

        private void pbSwordInv_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Sword"))
            {
                game.Equip("Sword");
                pbSword.BorderStyle = BorderStyle.Fixed3D;

                pbBow.BorderStyle = BorderStyle.None;
                pbMace.BorderStyle = BorderStyle.None;
                pbBluePotionInv.BorderStyle = BorderStyle.None;
                pbRedPotionInv.BorderStyle = BorderStyle.None;

                btnAtkUp.Visible = true;
                btnAtkDown.Visible = true;
                btnAtkRight.Visible = true;
                btnAtkLeft.Visible = true;

                btnDrink.Visible = false;
            }
        }

        private void pbBowInv_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Bow"))
            {
                game.Equip("Bow");
                pbBow.BorderStyle = BorderStyle.Fixed3D;

                pbSword.BorderStyle = BorderStyle.None;
                pbMace.BorderStyle = BorderStyle.None;
                pbBluePotionInv.BorderStyle = BorderStyle.None;
                pbRedPotionInv.BorderStyle = BorderStyle.None;

                btnAtkUp.Visible = true;
                btnAtkDown.Visible = true;
                btnAtkRight.Visible = true;
                btnAtkLeft.Visible = true;

                btnDrink.Visible = false;
            }
        }

        private void pbMaceInv_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Mace"))
            {
                game.Equip("Mace");
                pbMace.BorderStyle = BorderStyle.Fixed3D;

                pbSword.BorderStyle = BorderStyle.None;
                pbBow.BorderStyle = BorderStyle.None;
                pbBluePotionInv.BorderStyle = BorderStyle.None;
                pbRedPotionInv.BorderStyle = BorderStyle.None;

                btnAtkUp.Visible = true;
                btnAtkDown.Visible = true;
                btnAtkRight.Visible = true;
                btnAtkLeft.Visible = true;

                btnDrink.Visible = false;
            }
        }

        private void pbBluePotionInv_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("BluePotion"))
            {
                game.Equip("BluePotion");
                pbBluePotionInv.BorderStyle = BorderStyle.Fixed3D;

                pbSword.BorderStyle = BorderStyle.None;
                pbBow.BorderStyle = BorderStyle.None;
                pbMace.BorderStyle = BorderStyle.None;
                pbRedPotionInv.BorderStyle = BorderStyle.None;

                btnAtkUp.Visible = false;
                btnAtkDown.Visible = false;
                btnAtkRight.Visible = false;
                btnAtkLeft.Visible = false;

                btnDrink.Visible = true;
            }
        }

        private void pbRedPotionInv_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("RedPotion"))
            {
                game.Equip("RedPotion");
                pbRedPotionInv.BorderStyle = BorderStyle.Fixed3D;

                pbSword.BorderStyle = BorderStyle.None;
                pbBow.BorderStyle = BorderStyle.None;
                pbMace.BorderStyle = BorderStyle.None;
                pbBluePotionInv.BorderStyle = BorderStyle.None;

                btnAtkUp.Visible = false;
                btnAtkDown.Visible = false;
                btnAtkRight.Visible = false;
                btnAtkLeft.Visible = false;

                btnDrink.Visible = true;
            }
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();
        }

        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }

        private void btnAtkUp_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Up, random);
            UpdateCharacters();
        }

        private void btnAtkRight_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Right, random);
            UpdateCharacters();
        }

        private void btnAtkDown_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Down, random);
            UpdateCharacters();
        }

        private void btnAtkLeft_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
            UpdateCharacters();
        }
    }
}
