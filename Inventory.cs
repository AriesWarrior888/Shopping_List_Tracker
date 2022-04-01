using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Text.Json;

namespace Shopping_List_Tracker
{
    /*[4]"Regex Class (System)”, Docs.microsoft.com, 2022. [Online]. Available: https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex?view=net-6.0. [Accessed: 07- Mar- 2022].

[2]"JsonSerializer Class (System.Text.Json)", Docs.microsoft.com, 2022. [Online]. Available: https://docs.microsoft.com/en-us/dotnet/api/system.text.json.jsonserializer?view=net-6.0. [Accessed: 07- Mar- 2022].
    */
    public partial class Inventory : Form
    {
        private string fullPathToFile = string.Empty;
        private readonly string fileName = "inventory.Json";
        private string jsonString = string.Empty;
        public Storage[] ingredientList
        {
            get;set;
        }
        List<Control> currentControlList = new List<Control>();
        public Inventory()
        {
            InitializeComponent();
            InitializeFiles();
        }

        private void InitializeFiles()
        {
            fullPathToFile = System.IO.Path.Combine(Program.ApplicationDirectory, fileName);
            if (System.IO.File.Exists(fullPathToFile))
            {
                FileManager.ReadFromFile(fullPathToFile, out jsonString);
                List<Storage> deserializedList = JsonSerializer.Deserialize<List<Storage>>(jsonString);
                ingredientList = new Storage[deserializedList.Count];
                for (int i = 0; i < deserializedList.Count; i++)
                {
                    ingredientList[i] = deserializedList[i];
                    btnAdd_Click(deserializedList[i]);
                }
            }
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int removalIndex = flpInventory.Controls.IndexOf((Control)sender)-4;
            for (int i = 5; i < 9; i++)
            {
                currentControlList.Remove(currentControlList[removalIndex]);
                this.flpInventory.Controls.RemoveAt(removalIndex);
            }
        }

        private void btnAdd_Click(Storage storage)
        {
            Button btnNewDeleteButton = new Button();
            TextBox txtNewQty = new TextBox();
            TextBox txtNewName = new TextBox();
            ComboBox cbUOM = new ComboBox();

            //QTY box
            txtNewQty.Size = new System.Drawing.Size(100, 20);
            txtNewQty.Font = new System.Drawing.Font("Arial", 8);
            txtNewQty.Text = "" + storage.quantity;

            //Delete Button
            btnNewDeleteButton.Size = new System.Drawing.Size(75, 20);
            btnNewDeleteButton.Text = "Delete";
            btnNewDeleteButton.Click += new EventHandler(this.btnDelete_Click);

            //Name box
            txtNewName.Size = new System.Drawing.Size(300, 20);
            txtNewName.Font = new System.Drawing.Font("Arial", 8);
            txtNewName.Text = storage.ingredient.name;

            //UOM box
            cbUOM.Size = new System.Drawing.Size(126, 20);
            cbUOM.Font = new System.Drawing.Font("Arial", 8);
            cbUOM.Items.AddRange(Enum.GetNames(typeof(Ingredient.UnitOfMeasurement)));
            cbUOM.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUOM.Text = ""+storage.ingredient.measurement;


            //Adding to the Flow Layout Panel
            this.flpInventory.Controls.Add(txtNewName);
            this.flpInventory.Controls.Add(txtNewQty);
            this.flpInventory.Controls.Add(cbUOM);
            this.flpInventory.Controls.Add(btnNewDeleteButton);

            currentControlList.Add(txtNewName);
            currentControlList.Add(txtNewQty);
            currentControlList.Add(cbUOM);
            currentControlList.Add(btnNewDeleteButton);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Button btnNewDeleteButton = new Button();
            TextBox txtNewQty = new TextBox();
            TextBox txtNewName = new TextBox();
            ComboBox cbUOM = new ComboBox();

            //QTY box
            txtNewQty.Size = new System.Drawing.Size(100, 20);
            txtNewQty.Font = new System.Drawing.Font("Arial", 8);

            //Delete Button
            btnNewDeleteButton.Size = new System.Drawing.Size(75, 20); 
            btnNewDeleteButton.Text = "Delete";
            btnNewDeleteButton.Click += new EventHandler(this.btnDelete_Click);

            //Description box
            txtNewName.Size = new System.Drawing.Size(300, 20);
            txtNewName.Font = new System.Drawing.Font("Arial", 8);

            //UOM box
            cbUOM.Size = new System.Drawing.Size(126, 20);
            cbUOM.Font = new System.Drawing.Font("Arial", 8);
            cbUOM.Items.AddRange(Enum.GetNames(typeof(Ingredient.UnitOfMeasurement)));
            cbUOM.DropDownStyle = ComboBoxStyle.DropDownList;


            //Adding to the Flow Layout Panel
            this.flpInventory.Controls.Add(txtNewName);
            this.flpInventory.Controls.Add(txtNewQty);
            this.flpInventory.Controls.Add(cbUOM);
            this.flpInventory.Controls.Add(btnNewDeleteButton);

            currentControlList.Add(txtNewName);
            currentControlList.Add(txtNewQty);
            currentControlList.Add(cbUOM);
            currentControlList.Add(btnNewDeleteButton);

            
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ingredientList = new Storage[currentControlList.Count / 4];
            for(int i = 0; i < currentControlList.Count; i++)
            {
                if(currentControlList[i].Text.Equals(""))
                {
                    MessageBox.Show("A Box does not contain a value");
                    return;
                }
            }

            for(int i = 1; i < currentControlList.Count; i += 4)
            {
                if (!Regex.IsMatch(currentControlList[i].Text, @"^[0-9]+$"))
                {
                    MessageBox.Show("An amount box has non-number values");
                    return;
                }
            }

            for(int i = 0; i < currentControlList.Count; i += 4)
            {
                Ingredient ingredient = new Ingredient(currentControlList[i].Text, 0, (Ingredient.UnitOfMeasurement)Enum.Parse(typeof(Ingredient.UnitOfMeasurement), currentControlList[i + 2].Text));
                ingredientList[i/4] = (new Storage(Int32.Parse(currentControlList[i+1].Text),ingredient));
            }
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string jsonString = JsonSerializer.Serialize(ingredientList, options);
            FileManager.WriteToFile(fullPathToFile, jsonString);
            this.Close();



        }
    }
}
