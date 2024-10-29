using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AbstractFabric.Factories;
using AbstractFabric.Heroes;
using AbstractFabric.Armors;
using AbstractFabric.Weapons;

namespace AbstractFabric
{
    public partial class Form1 : Form
    {
        private HeroesFactory currentFactory;
        private heroes hero;
        private weapons weapon;
        private armors armor;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void SetFactory(HeroesFactory factory)
        {
            currentFactory = factory;
            hero = currentFactory.CreateHero();
            weapon = currentFactory.CreateWeapon();
            armor = currentFactory.CreateArmor();

            textBoxInfo.Text = $"Hero Type: {hero.Type}     " + $"Weapon Type: {weapon.Type}    " + $"Armor Type: {armor.Type}";
        }

        private void buttonArcher_Click(object sender, EventArgs e)
        {
            SetFactory(new ArcherFactory());
        }

        private void buttonWarrior_Click(object sender, EventArgs e)
        {
            SetFactory(new WarriorFactory());
        }

        private void buttonMage_Click(object sender, EventArgs e)
        {
            SetFactory(new MageFactory());
        }

        private void textBoxInfo_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
