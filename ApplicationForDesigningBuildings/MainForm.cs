using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace ApplicationForDesigningBuildings
{
    public partial class mainForm : Form
    {
        Bitmap bitmap;
        Graphics graphics;
        SolidBrush solidBrush;
        Pen pen;
        private Point p1;
        private Point p2;
        private Point p3;

        public mainForm()
        {
            InitializeComponent();
        }
        private Graphics CreatePanel(Panel drawPanel, Bitmap bitmap, Graphics graphics, string namePictureBox, int pictureWidth, int pictureHeight, int strokeWidth)
        {
            bitmap = new Bitmap(pictureWidth + strokeWidth, pictureHeight + strokeWidth);
            Panel panel = new Panel();

            panel.Name = namePictureBox;
            panel.Size = new Size(pictureWidth + strokeWidth, pictureHeight + strokeWidth);
            panel.BackgroundImage = bitmap;
            
            panel.Cursor = Cursors.SizeAll;
            panel.MouseDown += Panel_MouseDown;
            panel.MouseMove += Panel_MouseMove;
            panel.MouseUp += Panel_MouseUp;
            drawPanel.Controls.Add(panel);
            graphics = Graphics.FromImage(bitmap);
            DataWorker.DataPanel.Add(panel);
            return graphics;
        }


        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void addElementButton_Click(object sender, EventArgs e)
        {
            SettingElementsForm settingElementsForm = new SettingElementsForm();
            settingElementsForm.Owner = this;
            this.Enabled = false;

            if (settingElementsForm.ShowDialog() == DialogResult.OK)
            {
                if (settingElementsForm.chosenElement == 0)
                {
                    pen = new Pen
                    (
                        DataWorker.DataBuildingFrame[DataWorker.DataBuildingFrame.Count - 1].StrokeColor, 
                        DataWorker.DataBuildingFrame[DataWorker.DataBuildingFrame.Count - 1].StrokeWidth
                    );
                    if (DataWorker.DataBuildingFrame[DataWorker.DataBuildingFrame.Count - 1].InteriorElementColor != Color.Empty)
                    {
                        solidBrush = new SolidBrush
                        (
                            DataWorker.DataBuildingFrame[DataWorker.DataBuildingFrame.Count - 1].InteriorElementColor
                        );
                    }

                    Rectangle rectangle = new Rectangle
                    (
                       DataWorker.DataBuildingFrame[DataWorker.DataBuildingFrame.Count - 1].HorizontalPosition,
                       DataWorker.DataBuildingFrame[DataWorker.DataBuildingFrame.Count - 1].VerticalPosition,
                       DataWorker.DataBuildingFrame[DataWorker.DataBuildingFrame.Count - 1].Width,
                       DataWorker.DataBuildingFrame[DataWorker.DataBuildingFrame.Count - 1].Height
                    );

                    graphics = CreatePanel(drawPanel, bitmap, graphics, "BuildingFrame" + DataWorker.DataBuildingFrame.Count, DataWorker.DataBuildingFrame[DataWorker.DataBuildingFrame.Count - 1].Width, DataWorker.DataBuildingFrame[DataWorker.DataBuildingFrame.Count - 1].Height, 0);
                    DataWorker.DataPanel[DataWorker.DataPanel.Count - 1].BringToFront();

                    if (DataWorker.LastChangingPanel != null)
                    {
                        DataWorker.DataPanel[DataWorker.DataPanel.Count - 1].Location = new Point(DataWorker.LastChangingPanel.Location.X, DataWorker.LastChangingPanel.Location.Y);

                        for (int i = 0; i < DataWorker.DataPanel.Count; i++)
                        {
                            if (DataWorker.DataPanel[i].Name == DataWorker.LastChangingPanel.Name)
                            {
                                drawPanel.Controls.Remove(DataWorker.DataPanel[i]);
                                DataWorker.DataPanel.Remove(DataWorker.DataPanel[i]);
                                DataWorker.LastChangingPanel = null;
                                DataWorker.NameLastChangingPanel = null;
                            }
                        }
                    }

                    if (DataWorker.DataBuildingFrame[DataWorker.DataBuildingFrame.Count - 1].InteriorElementColor != Color.Empty)
                    {
                        graphics.FillRectangle(solidBrush, rectangle);
                    }
                    graphics.DrawRectangle(pen, rectangle);
                }
                else if (settingElementsForm.chosenElement == 1)
                {
                    pen = new Pen
                    (
                        DataWorker.DataDoor[DataWorker.DataDoor.Count - 1].StrokeColor,
                        DataWorker.DataDoor[DataWorker.DataDoor.Count - 1].StrokeWidth
                    );
                    if (DataWorker.DataDoor[DataWorker.DataDoor.Count - 1].InteriorElementColor != Color.Empty)
                    {
                        solidBrush = new SolidBrush
                        (
                            DataWorker.DataDoor[DataWorker.DataDoor.Count - 1].InteriorElementColor
                        );
                    }
                    Rectangle rect1 = new Rectangle
                    (
                        DataWorker.DataDoor[DataWorker.DataDoor.Count - 1].HorizontalPosition,
                        DataWorker.DataDoor[DataWorker.DataDoor.Count - 1].VerticalPosition,
                        DataWorker.DataDoor[DataWorker.DataDoor.Count - 1].Width,
                        DataWorker.DataDoor[DataWorker.DataDoor.Count - 1].Height
                    );

                    graphics = CreatePanel(drawPanel, bitmap, graphics, "Door" + DataWorker.DataDoor.Count, DataWorker.DataDoor[DataWorker.DataDoor.Count - 1].Width, DataWorker.DataDoor[DataWorker.DataDoor.Count - 1].Height, 0);
                    DataWorker.DataPanel[DataWorker.DataPanel.Count - 1].BringToFront();

                    if (DataWorker.LastChangingPanel != null)
                    {
                        DataWorker.DataPanel[DataWorker.DataPanel.Count - 1].Location = new Point(DataWorker.LastChangingPanel.Location.X, DataWorker.LastChangingPanel.Location.Y);

                        for (int i = 0; i < DataWorker.DataPanel.Count; i++)
                        {
                            if (DataWorker.DataPanel[i].Name == DataWorker.LastChangingPanel.Name)
                            {
                                drawPanel.Controls.Remove(DataWorker.DataPanel[i]);
                                DataWorker.DataPanel.Remove(DataWorker.DataPanel[i]);
                                DataWorker.LastChangingPanel = null;
                                DataWorker.NameLastChangingPanel = null;
                            }
                        }
                    }


                    if (DataWorker.DataDoor[DataWorker.DataDoor.Count - 1].InteriorElementColor != Color.Empty)
                    {
                        graphics.FillRectangle(solidBrush, rect1);
                    }
                    graphics.DrawRectangle(pen, rect1);
                }
                else if (settingElementsForm.chosenElement == 2)
                {
                    pen = new Pen
                    (
                        DataWorker.DataDoorHandle[DataWorker.DataDoorHandle.Count - 1].StrokeColor,
                        DataWorker.DataDoorHandle[DataWorker.DataDoorHandle.Count - 1].StrokeWidth
                    );

                    Rectangle rect1 = new Rectangle
                    (
                        DataWorker.DataDoorHandle[DataWorker.DataDoorHandle.Count - 1].HorizontalPosition,
                        DataWorker.DataDoorHandle[DataWorker.DataDoorHandle.Count - 1].VerticalPosition,
                        DataWorker.DataDoorHandle[DataWorker.DataDoorHandle.Count - 1].Width,
                        DataWorker.DataDoorHandle[DataWorker.DataDoorHandle.Count - 1].Height
                    );

                    graphics = CreatePanel(drawPanel, bitmap, graphics, "DoorHandle" + DataWorker.DataDoorHandle.Count, DataWorker.DataDoorHandle[DataWorker.DataDoorHandle.Count - 1].Width, DataWorker.DataDoorHandle[DataWorker.DataDoorHandle.Count - 1].Height, 0);
                    DataWorker.DataPanel[DataWorker.DataPanel.Count - 1].BringToFront();

                    if (DataWorker.LastChangingPanel != null)
                    {
                        DataWorker.DataPanel[DataWorker.DataPanel.Count - 1].Location = new Point(DataWorker.LastChangingPanel.Location.X, DataWorker.LastChangingPanel.Location.Y);

                        for (int i = 0; i < DataWorker.DataPanel.Count; i++)
                        {
                            if (DataWorker.DataPanel[i].Name == DataWorker.LastChangingPanel.Name)
                            {
                                drawPanel.Controls.Remove(DataWorker.DataPanel[i]);
                                DataWorker.DataPanel.Remove(DataWorker.DataPanel[i]);
                                DataWorker.LastChangingPanel = null;
                                DataWorker.NameLastChangingPanel = null;
                            }
                        }
                    }

                    graphics.DrawRectangle(pen, rect1);
                }
                else if (settingElementsForm.chosenElement == 3)
                {
                    pen = new Pen
                    (
                        DataWorker.DataRoof[DataWorker.DataRoof.Count - 1].StrokeColor,
                        DataWorker.DataRoof[DataWorker.DataRoof.Count - 1].StrokeWidth
                    );
                    if (DataWorker.DataRoof[DataWorker.DataRoof.Count - 1].InteriorElementColor != Color.Empty)
                    {
                        solidBrush = new SolidBrush
                        (
                            DataWorker.DataRoof[DataWorker.DataRoof.Count - 1].InteriorElementColor
                        );
                    }

                    p1 = new Point
                    (
                        DataWorker.DataRoof[DataWorker.DataRoof.Count - 1].HorizontalPosition + (DataWorker.DataRoof[DataWorker.DataRoof.Count - 1].Width / 2), 
                        DataWorker.DataRoof[DataWorker.DataRoof.Count - 1].VerticalPosition 
                    );
                    p2 = new Point
                    (
                        DataWorker.DataRoof[DataWorker.DataRoof.Count - 1].HorizontalPosition + DataWorker.DataRoof[DataWorker.DataRoof.Count - 1].Width,
                        DataWorker.DataRoof[DataWorker.DataRoof.Count - 1].VerticalPosition + DataWorker.DataRoof[DataWorker.DataRoof.Count - 1].Height
                    );
                    p3 = new Point
                    (
                        DataWorker.DataRoof[DataWorker.DataRoof.Count - 1].HorizontalPosition ,
                        DataWorker.DataRoof[DataWorker.DataRoof.Count - 1].VerticalPosition + DataWorker.DataRoof[DataWorker.DataRoof.Count - 1].Height
                    );

                    graphics = CreatePanel(drawPanel, bitmap, graphics, "Roof" + DataWorker.DataRoof.Count, DataWorker.DataRoof[DataWorker.DataRoof.Count - 1].Width, DataWorker.DataRoof[DataWorker.DataRoof.Count - 1].Height, DataWorker.DataRoof[DataWorker.DataRoof.Count - 1].StrokeWidth + DataWorker.DataRoof[DataWorker.DataRoof.Count - 1].StrokeWidth / 2 + 5);
                    DataWorker.DataPanel[DataWorker.DataPanel.Count - 1].BringToFront();

                    if (DataWorker.LastChangingPanel != null)
                    {
                        DataWorker.DataPanel[DataWorker.DataPanel.Count - 1].Location = new Point(DataWorker.LastChangingPanel.Location.X, DataWorker.LastChangingPanel.Location.Y);

                        for (int i = 0; i < DataWorker.DataPanel.Count; i++)
                        {
                            if (DataWorker.DataPanel[i].Name == DataWorker.LastChangingPanel.Name)
                            {
                                drawPanel.Controls.Remove(DataWorker.DataPanel[i]);
                                DataWorker.DataPanel.Remove(DataWorker.DataPanel[i]);
                                DataWorker.LastChangingPanel = null;
                                DataWorker.NameLastChangingPanel = null;
                            }
                        }
                    }

                    if (DataWorker.DataRoof[DataWorker.DataRoof.Count - 1].InteriorElementColor != Color.Empty)
                    {
                        graphics.FillPolygon(solidBrush, new Point[] { p1, p2, p3 });
                    }
                    graphics.DrawPolygon(pen, new Point[] { p1, p2, p3 });
                }
                else if (settingElementsForm.chosenElement == 4)
                {
                    pen = new Pen
                    (
                        DataWorker.DataWindow[DataWorker.DataWindow.Count - 1].StrokeColor,
                        DataWorker.DataWindow[DataWorker.DataWindow.Count - 1].StrokeWidth
                    );
                    if (DataWorker.DataWindow[DataWorker.DataWindow.Count - 1].InteriorElementColor != Color.Empty)
                    {
                        solidBrush = new SolidBrush
                        (
                            DataWorker.DataWindow[DataWorker.DataWindow.Count - 1].InteriorElementColor
                        );
                    }

                    Rectangle rect1 = new Rectangle
                    (
                        DataWorker.DataWindow[DataWorker.DataWindow.Count - 1].HorizontalPosition,
                        DataWorker.DataWindow[DataWorker.DataWindow.Count - 1].VerticalPosition,
                        DataWorker.DataWindow[DataWorker.DataWindow.Count - 1].Width,
                        DataWorker.DataWindow[DataWorker.DataWindow.Count - 1].Height
                    );

                    graphics = CreatePanel(drawPanel, bitmap, graphics, "Window" + DataWorker.DataWindow.Count, DataWorker.DataWindow[DataWorker.DataWindow.Count - 1].Width, DataWorker.DataWindow[DataWorker.DataWindow.Count - 1].Height, 0);
                    DataWorker.DataPanel[DataWorker.DataPanel.Count - 1].BringToFront();
                    if (DataWorker.LastChangingPanel != null)
                    {
                        DataWorker.DataPanel[DataWorker.DataPanel.Count - 1].Location = new Point(DataWorker.LastChangingPanel.Location.X, DataWorker.LastChangingPanel.Location.Y);

                        for (int i = 0; i < DataWorker.DataPanel.Count; i++)
                        {
                            if (DataWorker.DataPanel[i].Name == DataWorker.LastChangingPanel.Name)
                            {
                                drawPanel.Controls.Remove(DataWorker.DataPanel[i]);
                                DataWorker.DataPanel.Remove(DataWorker.DataPanel[i]);
                                DataWorker.LastChangingPanel = null;
                                DataWorker.NameLastChangingPanel = null;
                            }
                        }
                    }

                    if (DataWorker.DataWindow[DataWorker.DataWindow.Count - 1].InteriorElementColor != Color.Empty)
                    {
                        graphics.FillRectangle(solidBrush, rect1);
                    }
                    graphics.DrawRectangle(pen, rect1);
                }
                else if (settingElementsForm.chosenElement == 5)
                {
                    pen = new Pen
                    (
                        DataWorker.DataWindowCasement[DataWorker.DataWindowCasement.Count - 1].StrokeColor,
                        DataWorker.DataWindowCasement[DataWorker.DataWindowCasement.Count - 1].StrokeWidth
                    );

                    Rectangle rect1 = new Rectangle
                    (
                        DataWorker.DataWindowCasement[DataWorker.DataWindowCasement.Count - 1].HorizontalPosition,
                        DataWorker.DataWindowCasement[DataWorker.DataWindowCasement.Count - 1].VerticalPosition,
                        DataWorker.DataWindowCasement[DataWorker.DataWindowCasement.Count - 1].Width,
                        DataWorker.DataWindowCasement[DataWorker.DataWindowCasement.Count - 1].Height
                    );

                    graphics = CreatePanel(drawPanel, bitmap, graphics, "WindowCasement" + DataWorker.DataWindowCasement.Count, DataWorker.DataWindowCasement[DataWorker.DataWindowCasement.Count - 1].Width, DataWorker.DataWindowCasement[DataWorker.DataWindowCasement.Count - 1].Height, DataWorker.DataWindowCasement[DataWorker.DataWindowCasement.Count - 1].StrokeWidth / 2);
                    DataWorker.DataPanel[DataWorker.DataPanel.Count - 1].BringToFront();
                    if (DataWorker.LastChangingPanel != null)
                    {
                        DataWorker.DataPanel[DataWorker.DataPanel.Count - 1].Location = new Point(DataWorker.LastChangingPanel.Location.X, DataWorker.LastChangingPanel.Location.Y);

                        for (int i = 0; i < DataWorker.DataPanel.Count; i++)
                        {
                            if (DataWorker.DataPanel[i].Name == DataWorker.LastChangingPanel.Name)
                            {
                                drawPanel.Controls.Remove(DataWorker.DataPanel[i]);
                                DataWorker.DataPanel.Remove(DataWorker.DataPanel[i]);
                                DataWorker.LastChangingPanel = null;
                                DataWorker.NameLastChangingPanel = null;
                            }
                        }
                    }
                    graphics.DrawRectangle(pen, rect1);
                }
            }
            this.Enabled = true;
            this.Show();
        }
        Point lastPoint;
        string nameLastPanel;
        Panel lastPanel;

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (lastPanel == null)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (nameLastPanel != null)
                    {
                        for (int i = 0; i < DataWorker.DataPanel.Count; i++)
                        {
                            if (DataWorker.DataPanel[i].Name == nameLastPanel)
                            {
                                DataWorker.DataPanel[i].BorderStyle = BorderStyle.None;
                            }
                        }
                    }
                    lastPanel = sender as Panel;
                    lastPoint = new Point(e.X, e.Y);
                    nameLastPanel = lastPanel.Name;
                    lastPanel.BorderStyle = BorderStyle.Fixed3D;
                }
            }
        }
        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            lastPanel = null;
        }
        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (lastPanel != null)
            {
                if (e.Button == MouseButtons.Left)
                {
                    lastPanel.Left += e.X - lastPoint.X;
                    lastPanel.Top += e.Y - lastPoint.Y;
                }
            }
        }
        private void deleteElementButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DataWorker.DataPanel.Count; i++)
            {
                if (DataWorker.DataPanel[i].Name == nameLastPanel)
                {
                    drawPanel.Controls.Remove(DataWorker.DataPanel[i]);
                    DataWorker.DataPanel.Remove(DataWorker.DataPanel[i]);

                    for (int j = 0; j < DataWorker.DataBuildingFrame.Count; j++)
                    {
                        if (DataWorker.DataBuildingFrame[j].Name == nameLastPanel)
                        {
                            DataWorker.DataBuildingFrame.Remove(DataWorker.DataBuildingFrame[j]);
                        }
                    }
                    for (int j = 0; j < DataWorker.DataDoor.Count; j++)
                    {
                        if (DataWorker.DataDoor[j].Name == nameLastPanel)
                        {
                            DataWorker.DataDoor.Remove(DataWorker.DataDoor[j]);
                        }
                    }
                    for (int j = 0; j < DataWorker.DataDoorHandle.Count; j++)
                    {
                        if (DataWorker.DataDoorHandle[j].Name == nameLastPanel)
                        {
                            DataWorker.DataDoorHandle.Remove(DataWorker.DataDoorHandle[j]);
                        }
                    }
                    for (int j = 0; j < DataWorker.DataRoof.Count; j++)
                    {
                        if (DataWorker.DataRoof[j].Name == nameLastPanel)
                        {
                            DataWorker.DataRoof.Remove(DataWorker.DataRoof[j]);
                        }
                    }
                    for (int j = 0; j < DataWorker.DataWindow.Count; j++)
                    {
                        if (DataWorker.DataWindow[j].Name == nameLastPanel)
                        {
                            DataWorker.DataWindow.Remove(DataWorker.DataWindow[j]);
                        }
                    }
                    for (int j = 0; j < DataWorker.DataWindowCasement.Count; j++)
                    {
                        if (DataWorker.DataWindowCasement[j].Name == nameLastPanel)
                        {
                            DataWorker.DataWindowCasement.Remove(DataWorker.DataWindowCasement[j]);
                        }
                    }
                }
            }
        }
        private void layerHigherButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DataWorker.DataPanel.Count; i++)
            {
                if (DataWorker.DataPanel[i].Name == nameLastPanel)
                {
                    DataWorker.DataPanel[i].BringToFront();
                }
            }
        }
        private void layerBelowButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DataWorker.DataPanel.Count; i++)
            {
                if (DataWorker.DataPanel[i].Name == nameLastPanel)
                {
                    DataWorker.DataPanel[i].SendToBack();
                }
            }
        }

        private void drawPanel_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < DataWorker.DataPanel.Count; i++)
            {
                if (DataWorker.DataPanel[i].Name == nameLastPanel)
                {
                    DataWorker.DataPanel[i].BorderStyle = BorderStyle.None;
                    lastPanel = null;
                    nameLastPanel = null;
                }
            }
        }
        private void changeElementButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DataWorker.DataPanel.Count; i++)
            {
                if (DataWorker.DataPanel[i].Name == nameLastPanel)
                {
                    DataWorker.LastChangingPanel = DataWorker.DataPanel[i];
                }
            }
            DataWorker.NameLastChangingPanel = nameLastPanel;

            addElementButton_Click(sender,e);
            DataWorker.NameLastChangingPanel = string.Empty;
            DataWorker.LastChangingPanel = null;
        }
    }
}
