using System;
using System.Drawing;
using System.Windows.Forms;

namespace ApplicationForDesigningBuildings
{
    public partial class SettingElementsForm : Form
    {
        //Переменные
        string nameLastChangingPanel;
        string elementType;
        int elementSizeHeight;
        int elementSizeWidth;
        int strokeWidth;
        Color elementColor;
        Color elementInterior;
        public int chosenElement;



        public SettingElementsForm()
        {
            InitializeComponent();
        }
        private void SettingElementsForm_Load(object sender, EventArgs e)
        {
            nameLastChangingPanel = DataWorker.NameLastChangingPanel;
            if (nameLastChangingPanel != string.Empty)
            {
                for (int i = 0; i < DataWorker.DataBuildingFrame.Count; i++)
                {
                    if (nameLastChangingPanel == DataWorker.DataBuildingFrame[i].Name)
                    {
                        elementTypeComboBox.SelectedIndex = 0;
                        elementSizeHeightTextBox.Text = DataWorker.DataBuildingFrame[i].Height.ToString();
                        elementSizeWidthTextBox.Text = DataWorker.DataBuildingFrame[i].Width.ToString();
                        strokeThicknessTextBox.Text = DataWorker.DataBuildingFrame[i].StrokeWidth.ToString();

                        elementColorButton.BackColor = DataWorker.DataBuildingFrame[i].StrokeColor;
                        elementColorButton.ForeColor = DataWorker.DataBuildingFrame[i].StrokeColor;
                        elementColor = DataWorker.DataBuildingFrame[i].StrokeColor;

                        elementInteriorColorButton.BackColor = DataWorker.DataBuildingFrame[i].InteriorElementColor;
                        elementInteriorColorButton.ForeColor = DataWorker.DataBuildingFrame[i].InteriorElementColor;
                        elementInterior = DataWorker.DataBuildingFrame[i].InteriorElementColor;
                    }
                }
                for (int i = 0; i < DataWorker.DataDoor.Count; i++)
                {
                    if (nameLastChangingPanel == DataWorker.DataDoor[i].Name)
                    {
                        elementTypeComboBox.SelectedIndex = 1;
                        elementSizeHeightTextBox.Text = DataWorker.DataDoor[i].Height.ToString();
                        elementSizeWidthTextBox.Text = DataWorker.DataDoor[i].Width.ToString();
                        strokeThicknessTextBox.Text = DataWorker.DataDoor[i].StrokeWidth.ToString();

                        elementColorButton.BackColor = DataWorker.DataDoor[i].StrokeColor;
                        elementColorButton.ForeColor = DataWorker.DataDoor[i].StrokeColor;
                        elementColor = DataWorker.DataDoor[i].StrokeColor;

                        elementInteriorColorButton.BackColor = DataWorker.DataDoor[i].InteriorElementColor;
                        elementInteriorColorButton.ForeColor = DataWorker.DataDoor[i].InteriorElementColor;
                        elementInterior = DataWorker.DataDoor[i].InteriorElementColor;
                    }
                }
                for (int i = 0; i < DataWorker.DataDoorHandle.Count; i++)
                {
                    if (nameLastChangingPanel == DataWorker.DataDoorHandle[i].Name)
                    {
                        elementTypeComboBox.SelectedIndex = 2;
                        elementSizeHeightTextBox.Text = DataWorker.DataDoorHandle[i].Height.ToString();
                        elementSizeWidthTextBox.Text = DataWorker.DataDoorHandle[i].Width.ToString();
                        strokeThicknessTextBox.Text = DataWorker.DataDoorHandle[i].StrokeWidth.ToString();

                        elementColorButton.BackColor = DataWorker.DataDoorHandle[i].StrokeColor;
                        elementColorButton.ForeColor = DataWorker.DataDoorHandle[i].StrokeColor;
                        elementColor = DataWorker.DataDoorHandle[i].StrokeColor;
                    }
                }
                for (int i = 0; i < DataWorker.DataRoof.Count; i++)
                {
                    if (nameLastChangingPanel == DataWorker.DataRoof[i].Name)
                    {
                        elementTypeComboBox.SelectedIndex = 3;
                        elementSizeHeightTextBox.Text = DataWorker.DataRoof[i].Height.ToString();
                        elementSizeWidthTextBox.Text = DataWorker.DataRoof[i].Width.ToString();
                        strokeThicknessTextBox.Text = DataWorker.DataRoof[i].StrokeWidth.ToString();

                        elementColorButton.BackColor = DataWorker.DataRoof[i].StrokeColor;
                        elementColorButton.ForeColor = DataWorker.DataRoof[i].StrokeColor;
                        elementColor = DataWorker.DataRoof[i].StrokeColor;

                        elementInteriorColorButton.BackColor = DataWorker.DataRoof[i].InteriorElementColor;
                        elementInteriorColorButton.ForeColor = DataWorker.DataRoof[i].InteriorElementColor;
                        elementInterior = DataWorker.DataRoof[i].InteriorElementColor;
                    }
                }
                for (int i = 0; i < DataWorker.DataWindow.Count; i++)
                {
                    if (nameLastChangingPanel == DataWorker.DataWindow[i].Name)
                    {
                        elementTypeComboBox.SelectedIndex = 4;
                        elementSizeHeightTextBox.Text = DataWorker.DataWindow[i].Height.ToString();
                        elementSizeWidthTextBox.Text = DataWorker.DataWindow[i].Width.ToString();
                        strokeThicknessTextBox.Text = DataWorker.DataWindow[i].StrokeWidth.ToString();

                        elementColorButton.BackColor = DataWorker.DataWindow[i].StrokeColor;
                        elementColorButton.ForeColor = DataWorker.DataWindow[i].StrokeColor;
                        elementColor = DataWorker.DataWindow[i].StrokeColor;

                        elementInteriorColorButton.BackColor = DataWorker.DataWindow[i].InteriorElementColor;
                        elementInteriorColorButton.ForeColor = DataWorker.DataWindow[i].InteriorElementColor;
                        elementInterior = DataWorker.DataWindow[i].InteriorElementColor;
                    }
                }
                for (int i = 0; i < DataWorker.DataWindowCasement.Count; i++)
                {
                    if (nameLastChangingPanel == DataWorker.DataWindowCasement[i].Name)
                    {
                        elementTypeComboBox.SelectedIndex = 5;
                        elementSizeHeightTextBox.Text = DataWorker.DataWindowCasement[i].Height.ToString();
                        elementSizeWidthTextBox.Text = DataWorker.DataWindowCasement[i].Width.ToString();
                        strokeThicknessTextBox.Text = DataWorker.DataWindowCasement[i].StrokeWidth.ToString();

                        elementColorButton.BackColor = DataWorker.DataWindowCasement[i].StrokeColor;
                        elementColorButton.ForeColor = DataWorker.DataWindowCasement[i].StrokeColor;
                        elementColor = DataWorker.DataWindowCasement[i].StrokeColor;
                    }
                }
            }
        }
        private void elementColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            elementColorButton.BackColor = colorDialog1.Color;
            elementColorButton.ForeColor = colorDialog1.Color;

            elementColor = colorDialog1.Color;
        }

        private void elementInteriorColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog2 = new ColorDialog();
            if (colorDialog2.ShowDialog() == DialogResult.Cancel)
                return;
            elementInteriorColorButton.BackColor = colorDialog2.Color;
            elementInteriorColorButton.ForeColor = colorDialog2.Color;

            elementInterior = colorDialog2.Color;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            //Валидация
            if (elementTypeComboBox.Text.Length == 0 || elementSizeHeightTextBox.Text.Length == 0 ||
            elementSizeWidthTextBox.Text.Length == 0 || strokeThicknessTextBox.Text.Length == 0)
            {
                MessageBox.Show("Введите данные во все поля!", "Внимание");
                return;
            }
            for (int i = 0; i < elementSizeHeightTextBox.Text.Length; i++)
            {
                if (Char.IsNumber(elementSizeHeightTextBox.Text[i]) == false)
                {
                    MessageBox.Show("Первая ячейка 'Размера элемента' может содержать только число", "Внимание");
                    return;
                }
            }
            if (Convert.ToInt32(elementSizeHeightTextBox.Text) <= 0)
            {
                MessageBox.Show("Первая ячейка 'Размера элемента' должна быть больше 0", "Внимание");
                return;
            }
            for (int i = 0; i < elementSizeWidthTextBox.Text.Length; i++)
            {
                if (Char.IsNumber(elementSizeWidthTextBox.Text[i]) == false)
                {
                    MessageBox.Show("Вторая ячейка 'Размера элемента' может содержать только число", "Внимание");
                    return;
                }
            }
            if (Convert.ToInt32(elementSizeWidthTextBox.Text) <= 0)
            {
                MessageBox.Show("Вторая ячейка 'Размера элемента' должна быть больше 0", "Внимание");
                return;
            }
            for (int i = 0; i < strokeThicknessTextBox.Text.Length; i++)
            {
                if (Char.IsNumber(strokeThicknessTextBox.Text[i]) == false)
                {
                    MessageBox.Show("Толщина обводки может содержать только число", "Внимание");
                    return;
                }
            }
            if (Convert.ToInt32(strokeThicknessTextBox.Text) < 0)
            {
                MessageBox.Show("Толщина обводки должна быть больше или равно 0", "Внимание");
                return;
            }
            if (elementColor == Color.Empty && elementInterior == Color.Empty)
            {
                MessageBox.Show("Выберите цвет обводки или цвет внутри элемента", "Внимание");
                return;
            }
            if (elementColor != Color.Empty && Convert.ToInt32(strokeThicknessTextBox.Text) == 0)
            {
                MessageBox.Show("Нельзя устанавливать цвет обводки, если её ширина равна нулю", "Внимание");
                return;
            }


            elementType = elementTypeComboBox.Text;
            elementSizeHeight = Convert.ToInt32(elementSizeHeightTextBox.Text);
            elementSizeWidth = Convert.ToInt32(elementSizeWidthTextBox.Text);
            strokeWidth = Convert.ToInt32(strokeThicknessTextBox.Text);

            if (elementTypeComboBox.SelectedIndex == 0)
            {
                DataWorker.DataBuildingFrame.Add(new BuildingFrame()
                {
                    Name = "BuildingFrame" + (DataWorker.DataBuildingFrame.Count + 1),
                    Width = elementSizeWidth,
                    Height = elementSizeHeight,
                    StrokeWidth = strokeWidth,
                    HorizontalPosition = 0,
                    VerticalPosition = 0,
                    StrokeColor = elementColor,
                    InteriorElementColor = elementInterior,
                });
                chosenElement = 0;
            }
            else if (elementTypeComboBox.SelectedIndex == 1)
            {
                DataWorker.DataDoor.Add(new Door()
                {
                    Name = "Door" + (DataWorker.DataDoor.Count + 1),
                    Width = elementSizeWidth,
                    Height = elementSizeHeight,
                    StrokeWidth = strokeWidth,
                    HorizontalPosition = 0,
                    VerticalPosition = 0,
                    StrokeColor = elementColor,
                    InteriorElementColor = elementInterior,
                });
                chosenElement = 1;
            }
            else if (elementTypeComboBox.SelectedIndex == 2)
            {
                DataWorker.DataDoorHandle.Add(new DoorHandle()
                {
                    Name = "DoorHandle" + (DataWorker.DataDoorHandle.Count + 1),
                    Width = elementSizeWidth,
                    Height = elementSizeHeight,
                    StrokeWidth = strokeWidth,
                    HorizontalPosition = 0,
                    VerticalPosition = 0,
                    StrokeColor = elementColor,
                });
                chosenElement = 2;
            }
            else if (elementTypeComboBox.SelectedIndex == 3)
            {
                DataWorker.DataRoof.Add(new Roof()
                {
                    Name = "Roof" + (DataWorker.DataRoof.Count + 1),
                    Width = elementSizeWidth,
                    Height = elementSizeHeight,
                    StrokeWidth = strokeWidth,
                    HorizontalPosition = strokeWidth,
                    VerticalPosition = strokeWidth,
                    StrokeColor = elementColor,
                    InteriorElementColor = elementInterior,
                });
                chosenElement = 3;
            }
            else if (elementTypeComboBox.SelectedIndex == 4)
            {
                DataWorker.DataWindow.Add(new Window()
                {
                    Name = "Window" + (DataWorker.DataWindow.Count + 1),
                    Width = elementSizeWidth,
                    Height = elementSizeHeight,
                    StrokeWidth = strokeWidth,
                    HorizontalPosition = 0,
                    VerticalPosition = 0,
                    StrokeColor = elementColor,
                    InteriorElementColor = elementInterior,
                });
                chosenElement = 4;
            }
            else if (elementTypeComboBox.SelectedIndex == 5)
            {
                DataWorker.DataWindowCasement.Add(new WindowCasement()
                {
                    Name = "WindowCasement" + (DataWorker.DataWindowCasement.Count + 1),
                    Width = elementSizeWidth,
                    Height = elementSizeHeight,
                    StrokeWidth = strokeWidth,
                    HorizontalPosition = 0,
                    VerticalPosition = 0,
                    StrokeColor = elementColor,
                });
                chosenElement = 5;
            }
            DialogResult = DialogResult.OK;
        }

        private void elementTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (elementTypeComboBox.SelectedIndex == 2 || elementTypeComboBox.SelectedIndex == 5)
            {
                elementInteriorColorButton.Enabled = false;
                elementInteriorColorLabel.Enabled = false;
                return;
            }
            elementInteriorColorButton.Enabled = true;
            elementInteriorColorLabel.Enabled = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
