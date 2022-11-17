using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using UserControl = System.Windows.Forms.UserControl;


namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Хранит логику обработки событий окна.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Создает товары с автоматически заполненными данными.
        /// </summary>
        private ItemFactory _itemFactory;

        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Текущий товар.
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// Возвращает и задает список товаров.
        /// </summary>
        //[Browsable(false)]
        //[EditorBrowsable(EditorBrowsableState.Never)]
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;

                if (Items.Count != 0)
                {
                    foreach (var item in Items)
                    {
                        ItemsListBox.Items.Add(item.Name);
                    }

                    ItemsListBox.SelectedIndex = 0;
                }
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="ItemsTab"/>
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();

            _itemFactory = new ItemFactory();

            foreach (var category in Enum.GetValues(typeof(Category)))
            {
                CategoryComboBox.Items.Add(category);
            }           

            CheckingAvailabilityItems();
        }

        /// <summary>
        /// Обновляет все текстовые поля значениями выбранного товара.
        /// </summary>
        private void UpdateTextBoxes(Item item)
        {           
            CostTextBox.Text = item.Cost.ToString();
            NameTextBox.Text = item.Name;
            DescriptionTextBox.Text = item.Description;
            IDTextBox.Text = item.Id.ToString();
            CategoryComboBox.SelectedItem = item.Category;
        }

        /// <summary>
        /// Очищает все текстовые поля.
        /// </summary>
        private void ClearTextBoxes()
        {
            CostTextBox.Clear();
            NameTextBox.Clear();
            DescriptionTextBox.Clear();
            IDTextBox.Clear();
            CategoryComboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Проверяет есть ли в списке товары.
        /// Если есть, то делает текстовые поля доступными.
        /// </summary>
        private void CheckingAvailabilityItems()
        {
            if (Items.Count == 0)
            {
                CostTextBox.Enabled = false;
                NameTextBox.Enabled = false;
                DescriptionTextBox.Enabled = false;
                CategoryComboBox.Enabled = false;

                ClearTextBoxes();
            }
            else
            {
                CostTextBox.Enabled = true;
                NameTextBox.Enabled = true;
                DescriptionTextBox.Enabled = true;
                CategoryComboBox.Enabled = true;
            }            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentItem = new Item();

            Items.Add(_currentItem);
            ItemsListBox.Items.Add(_currentItem.Name);

            ItemsListBox.SelectedIndex = Items.Count - 1;

            UpdateTextBoxes(_currentItem);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.Items.Count == 0) return;

            int index = ItemsListBox.SelectedIndex;          

            ItemsListBox.Items.RemoveAt(index);
            Items.RemoveAt(index);

            ItemsListBox.SelectedIndex = Items.Count > 0 ? 0 : -1;
            
            UpdateTextBoxes(_currentItem);
            CheckingAvailabilityItems();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {           
            _currentItem = _itemFactory.CreatItem();

            Items.Add(_currentItem);
            ItemsListBox.Items.Add(_currentItem.Name);

            ItemsListBox.SelectedIndex = Items.Count - 1;

            UpdateTextBoxes(_currentItem);
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {           
            int index = ItemsListBox.SelectedIndex;

            if (index == -1) return;
            
            _currentItem = Items[index];
           
            UpdateTextBoxes(_currentItem);
            CheckingAvailabilityItems();
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CostTextBox.BackColor = AppColor.NormalBackColor;
                _currentItem.Cost = Convert.ToDouble(CostTextBox.Text);
            }
            catch(Exception ex)
            {
                CostTextBox.BackColor = AppColor.ErrorBackColor;
                CostToolTip.SetToolTip(CostTextBox, ex.Message);

                if (Items.Count == 0)
                    CostTextBox.BackColor = AppColor.NormalBackColor;
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NameTextBox.BackColor = AppColor.NormalBackColor;
                _currentItem.Name = NameTextBox.Text;
                ItemsListBox.
                    Items[Items.IndexOf(_currentItem)] = _currentItem.Name;
            }
            catch (Exception ex)
            {
                NameTextBox.BackColor = AppColor.ErrorBackColor;
                NameToolTip.SetToolTip(NameTextBox, ex.Message);

                if (Items.Count == 0) 
                    NameTextBox.BackColor = AppColor.NormalBackColor;
            }
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DescriptionTextBox.BackColor = AppColor.NormalBackColor;
                _currentItem.Description = DescriptionTextBox.Text;
            }
            catch (Exception ex)
            {
                DescriptionTextBox.BackColor = AppColor.ErrorBackColor;
                DescriptionToolTip.SetToolTip(DescriptionTextBox, ex.Message);
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CategoryComboBox.BackColor = AppColor.NormalBackColor;
                _currentItem.Category = (Category)CategoryComboBox.SelectedIndex;
            }
            catch
            {
                CategoryComboBox.BackColor = AppColor.ErrorBackColor;
            }
        }
    }
}
