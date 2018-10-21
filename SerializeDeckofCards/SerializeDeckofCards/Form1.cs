using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerializeDeckofCards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Random random = new Random();

        private Deck randomDeck(int number)
        {
            Deck myDeck = new Deck(new Card[] { });

            for(int i = 0; i < number; i++)
            {
                myDeck.Add(new Card((Suits)random.Next(1, 4), (Values)random.Next(1, 14)));
            }
            return myDeck;
        }
        private void dealCards(Deck deckToDeal, string title)
        {
            Console.WriteLine(title);

            while(deckToDeal.Count > 0)
            {
                Card nextCard = deckToDeal.Deal(0);
                Console.WriteLine(nextCard.Name);
            }
            Console.WriteLine("-------------------");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deck deckToWrite = randomDeck(5);

            using (Stream output = File.Create("Deck.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(output, deckToWrite);
            }
            dealCards(deckToWrite, "What I just wrote to the file");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using(Stream input = File.OpenRead("Deck.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                Deck deckFromFile = (Deck)bf.Deserialize(input);
                dealCards(deckFromFile, "What I read from the file");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using(Stream output = File.Create("Deck2.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                for(int i = 1; i <= 5; i++)
                {
                    Deck deckToWrite = randomDeck(random.Next(1, 10));
                    bf.Serialize(output, deckToWrite);
                    dealCards(deckToWrite, "Deck # " + i + " written");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using(Stream input = File.OpenRead("Deck2.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();

                for(int i = 1; i <= 5; i++)
                {
                    Deck deckToRead = (Deck)bf.Deserialize(input);
                    dealCards(deckToRead, "Deck # " + i + " read");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Deck mydeck = new Deck(new Card[] { });
            mydeck.Add(new Card((Suits)1, (Values)3));

            using (Stream output = File.Create("threeOfClubs.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(output, mydeck);
                dealCards(mydeck, "Three of clubs has been written");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Deck mydeck = new Deck(new Card[] { });
            mydeck.Add(new Card((Suits)3, (Values)6));

            using (Stream output = File.Create("sixOfHearts.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(output, mydeck);
                dealCards(mydeck, "Six of hearts has been written");
            }
        }
    }
}
