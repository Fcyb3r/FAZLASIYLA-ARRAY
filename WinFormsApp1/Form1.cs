using System.Collections;
using System.Collections.Specialized;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        private ArrayList birDizi;
        private StringCollection stringList;
        private StringDictionary asd;
        private Stack stackObject;
        private Queue queueObject;
        private Hashtable hashTable;
        private Hashtable hashTabl;
        private SortedList sortedList;

        private string[] names = new string[] { "Joydip", "Jini" };

        private int[] list = new int[5];
        private int sayaç = 0;


        public Form1()
        {
            InitializeComponent();
            birDizi = new ArrayList();
            birDizi.Add(12);
            birDizi.Add(3);
            birDizi.Add(8);
            birDizi.Add(7);
            birDizi.Add(15);


            stringList = new StringCollection();
            stringList.Add("Manisa");
            stringList.Add("Konya");
            stringList.Add("Kayseri");
            stringList.Add("Van");

            asd = new StringDictionary();
            asd.Add("A", "Manisa");
            asd.Add("B", "Konya");
            asd.Add("C", "Kayseri");
            asd.Add("D", "Van");



            stackObject = new Stack();
            stackObject.Push("Sinop");
            stackObject.Push("Diyarbakýr");
            stackObject.Push("Edirne");
            stackObject.Push("Muþ");
            stackObject.Push("Aydýn");
            stackObject.Push("Trabzon");


            queueObject = new Queue();
            queueObject.Enqueue("Lale");
            queueObject.Enqueue("Gül");
            queueObject.Enqueue("Menekçe");
            queueObject.Enqueue("Sümbül");
            queueObject.Enqueue("Çiðdem");
            queueObject.Enqueue("Yasemin");

            hashTable = new Hashtable();
            hashTable.Add(1, "Gökova");
            hashTable.Add(2, "Belek");
            hashTable.Add(3, "Çamdibi");
            hashTable.Add(4, "Marmaris");


            hashTabl = new Hashtable();
            hashTabl.Add(1, "Matematik");
            hashTabl.Add(2, "Fizik");
            hashTabl.Add(3, "Kimya");
            hashTabl.Add(4, "Biyoloji");
            hashTabl.Add(5, "Bilgisayar");
            hashTabl.Add(6, "Jeoloji");


            sortedList = new SortedList();
            sortedList.Add(1, "Matematik");
            sortedList.Add(2, "Fizik");
            sortedList.Add(3, "Kimya");
            sortedList.Add(4, "Biyoloji");
            sortedList.Add(5, "Bilgisayar");
            sortedList.Add(6, "Jeoloji");












        }

        public void button1_Click(object sender, EventArgs e)
        {



            textBox1.Clear();

            // ArrayList'teki her öðeyi TextBox'a yaz
            foreach (int n in birDizi)
            {
                textBox1.AppendText(n.ToString() + Environment.NewLine);
            }

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {




        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArrayList birDizi = new ArrayList();
            birDizi.Add("Zonguldak");
            birDizi.Add("Urfa");
            birDizi.Add("Adana");
            birDizi.Add("Bursa");
            birDizi.Add("Ýzmir");




            listBox1.Items.Clear(); // ListBox'ý temizle (yeniden doldurmadan önce)

            // ArrayList'teki öðeleri ListBox'a ekleyin
            foreach (string s in birDizi)
            {
                listBox1.Items.Add(s);
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int k = 1; k <= 10; k++)
            {
                listBox2.Items.Add(k);
            }

            // 8 sayýsýný ListBox'tan kaldýrmak için
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                if (listBox2.Items[i].ToString() == "8")
                {
                    listBox2.Items.RemoveAt(i);

                }
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int k = 1; k <= 10; k++)
            {
                listBox3.Items.Add(k);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

            int i = 10;
            double d = 17.3;
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Baþkent");
            arrayList.Add(i);
            arrayList.Add(d);

            foreach (var item in arrayList)
            {
                listBox4.Items.Add(item.ToString());
            }


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int i = 10;
            double d = 17.3;
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Baþkent");
            arrayList.Add(i);
            arrayList.Add(d);

            foreach (var item in arrayList)
            {
                listBox5.Items.Add(item.ToString());
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox6.Items.Clear(); // ListView'i temizle
            foreach (string item in stringList)
            {
                listBox6.Items.Add(item);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox7.Items.Clear(); // ListBox'ý temizle

            foreach (string str in stringList)
            {
                listBox7.Items.Add(str);
            }







        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox8.Items.Clear();

            while (stackObject.Count > 0)
            {
                listBox8.Items.Add(stackObject.Pop());
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox9.Items.Clear();

            while (queueObject.Count > 0)
            {
                listBox9.Items.Add(queueObject.Dequeue());
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {



            listBox10.Items.Clear();

            foreach (int key in hashTable.Keys)
            {
                listBox10.Items.Add($"{key}: {hashTable[key]}");
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            listBox11.Items.Clear();

            foreach (int key in hashTable.Keys)
            {
                listBox11.Items.Add($"{key}: {hashTable[key]}");
            }




        }

        private void button13_Click(object sender, EventArgs e)
        {
            listBox12.Items.Clear();

            IDictionaryEnumerator en = sortedList.GetEnumerator();
            while (en.MoveNext())
            {
                listBox12.Items.Add(en.Value);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

            listBox13.Items.Clear();

            IDictionaryEnumerator en = sortedList.GetEnumerator();
            while (en.MoveNext())
            {
                listBox13.Items.Add(en.Value);
            }

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            listBox14.Items.Clear();

            foreach (string name in names)
            {
                listBox14.Items.Add(name);
            }


        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            listBox15.Items.Clear(); // ListBox'ý temizle

            for (int i = 1; i <= 20; i++)
            {
                add(i);
            }

            Console.WriteLine("length = " + sayaç);
            Console.Write("kents = ");
            for (int i = 0; i < sayaç; i++)
            {
                Console.Write(list[i] + " ");
                listBox15.Items.Add(list[i]);
            }
            Console.WriteLine();
        }

        private void add(int k)
        {
            if (sayaç == list.Length)
            {
                int[] newlist = new int[sayaç + 1];
                for (int i = 0; i < sayaç; i++)
                {
                    newlist[i] = list[i];
                }
                list = newlist;
            }
            list[sayaç++] = k;
        }
    }
    }



