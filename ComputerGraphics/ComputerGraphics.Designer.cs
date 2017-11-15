﻿using System.ComponentModel;
using System.Windows.Forms;

namespace ComputerGraphics
{
    partial class ComputerGraphics
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.groupBoxSecondPoint = new System.Windows.Forms.GroupBox();
            this.numericUpDownSecondY = new System.Windows.Forms.NumericUpDown();
            this.labelSecondY = new System.Windows.Forms.Label();
            this.numericUpDownSecondX = new System.Windows.Forms.NumericUpDown();
            this.labelSecondX = new System.Windows.Forms.Label();
            this.groupBoxFirstPoint = new System.Windows.Forms.GroupBox();
            this.numericUpDownFirstY = new System.Windows.Forms.NumericUpDown();
            this.labelFirstY = new System.Windows.Forms.Label();
            this.numericUpDownFirstX = new System.Windows.Forms.NumericUpDown();
            this.labelFirstX = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxEllipse = new System.Windows.Forms.GroupBox();
            this.buttonDrawEllipse = new System.Windows.Forms.Button();
            this.numericUpDownB = new System.Windows.Forms.NumericUpDown();
            this.labelB = new System.Windows.Forms.Label();
            this.numericUpDownA = new System.Windows.Forms.NumericUpDown();
            this.labelA = new System.Windows.Forms.Label();
            this.groupBoxCircle = new System.Windows.Forms.GroupBox();
            this.buttonDrawCircle = new System.Windows.Forms.Button();
            this.numericUpDownRadius = new System.Windows.Forms.NumericUpDown();
            this.labelRadius = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.tabPage14 = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxSecondPoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSecondY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSecondX)).BeginInit();
            this.groupBoxFirstPoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFirstY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFirstX)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBoxEllipse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).BeginInit();
            this.groupBoxCircle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRadius)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(900, 600);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Controls.Add(this.tabPage6);
            this.tabControl.Controls.Add(this.tabPage7);
            this.tabControl.Controls.Add(this.tabPage8);
            this.tabControl.Controls.Add(this.tabPage9);
            this.tabControl.Controls.Add(this.tabPage10);
            this.tabControl.Controls.Add(this.tabPage11);
            this.tabControl.Controls.Add(this.tabPage12);
            this.tabControl.Controls.Add(this.tabPage13);
            this.tabControl.Controls.Add(this.tabPage14);
            this.tabControl.ItemSize = new System.Drawing.Size(26, 18);
            this.tabControl.Location = new System.Drawing.Point(902, 1);
            this.tabControl.Margin = new System.Windows.Forms.Padding(1);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(195, 426);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonDraw);
            this.tabPage1.Controls.Add(this.groupBoxSecondPoint);
            this.tabPage1.Controls.Add(this.groupBoxFirstPoint);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(187, 382);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "2";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonDraw
            // 
            this.buttonDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDraw.Location = new System.Drawing.Point(54, 306);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(87, 31);
            this.buttonDraw.TabIndex = 12;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // groupBoxSecondPoint
            // 
            this.groupBoxSecondPoint.Controls.Add(this.numericUpDownSecondY);
            this.groupBoxSecondPoint.Controls.Add(this.labelSecondY);
            this.groupBoxSecondPoint.Controls.Add(this.numericUpDownSecondX);
            this.groupBoxSecondPoint.Controls.Add(this.labelSecondX);
            this.groupBoxSecondPoint.Location = new System.Drawing.Point(14, 175);
            this.groupBoxSecondPoint.Margin = new System.Windows.Forms.Padding(25);
            this.groupBoxSecondPoint.Name = "groupBoxSecondPoint";
            this.groupBoxSecondPoint.Size = new System.Drawing.Size(148, 103);
            this.groupBoxSecondPoint.TabIndex = 11;
            this.groupBoxSecondPoint.TabStop = false;
            this.groupBoxSecondPoint.Text = "Second point";
            // 
            // numericUpDownSecondY
            // 
            this.numericUpDownSecondY.Location = new System.Drawing.Point(55, 66);
            this.numericUpDownSecondY.Margin = new System.Windows.Forms.Padding(10);
            this.numericUpDownSecondY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownSecondY.Name = "numericUpDownSecondY";
            this.numericUpDownSecondY.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownSecondY.TabIndex = 2;
            // 
            // labelSecondY
            // 
            this.labelSecondY.AutoSize = true;
            this.labelSecondY.Location = new System.Drawing.Point(19, 68);
            this.labelSecondY.Name = "labelSecondY";
            this.labelSecondY.Size = new System.Drawing.Size(23, 13);
            this.labelSecondY.TabIndex = 5;
            this.labelSecondY.Text = "Y : ";
            // 
            // numericUpDownSecondX
            // 
            this.numericUpDownSecondX.Location = new System.Drawing.Point(55, 26);
            this.numericUpDownSecondX.Margin = new System.Windows.Forms.Padding(10);
            this.numericUpDownSecondX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownSecondX.Name = "numericUpDownSecondX";
            this.numericUpDownSecondX.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownSecondX.TabIndex = 1;
            // 
            // labelSecondX
            // 
            this.labelSecondX.AutoSize = true;
            this.labelSecondX.Location = new System.Drawing.Point(19, 28);
            this.labelSecondX.Name = "labelSecondX";
            this.labelSecondX.Size = new System.Drawing.Size(23, 13);
            this.labelSecondX.TabIndex = 4;
            this.labelSecondX.Text = "X : ";
            // 
            // groupBoxFirstPoint
            // 
            this.groupBoxFirstPoint.Controls.Add(this.numericUpDownFirstY);
            this.groupBoxFirstPoint.Controls.Add(this.labelFirstY);
            this.groupBoxFirstPoint.Controls.Add(this.numericUpDownFirstX);
            this.groupBoxFirstPoint.Controls.Add(this.labelFirstX);
            this.groupBoxFirstPoint.Location = new System.Drawing.Point(14, 54);
            this.groupBoxFirstPoint.Margin = new System.Windows.Forms.Padding(25);
            this.groupBoxFirstPoint.Name = "groupBoxFirstPoint";
            this.groupBoxFirstPoint.Size = new System.Drawing.Size(148, 103);
            this.groupBoxFirstPoint.TabIndex = 10;
            this.groupBoxFirstPoint.TabStop = false;
            this.groupBoxFirstPoint.Text = "First point";
            // 
            // numericUpDownFirstY
            // 
            this.numericUpDownFirstY.Location = new System.Drawing.Point(55, 66);
            this.numericUpDownFirstY.Margin = new System.Windows.Forms.Padding(10);
            this.numericUpDownFirstY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownFirstY.Name = "numericUpDownFirstY";
            this.numericUpDownFirstY.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownFirstY.TabIndex = 2;
            // 
            // labelFirstY
            // 
            this.labelFirstY.AutoSize = true;
            this.labelFirstY.Location = new System.Drawing.Point(19, 68);
            this.labelFirstY.Name = "labelFirstY";
            this.labelFirstY.Size = new System.Drawing.Size(23, 13);
            this.labelFirstY.TabIndex = 5;
            this.labelFirstY.Text = "Y : ";
            // 
            // numericUpDownFirstX
            // 
            this.numericUpDownFirstX.Location = new System.Drawing.Point(55, 26);
            this.numericUpDownFirstX.Margin = new System.Windows.Forms.Padding(10);
            this.numericUpDownFirstX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownFirstX.Name = "numericUpDownFirstX";
            this.numericUpDownFirstX.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownFirstX.TabIndex = 1;
            // 
            // labelFirstX
            // 
            this.labelFirstX.AutoSize = true;
            this.labelFirstX.Location = new System.Drawing.Point(19, 28);
            this.labelFirstX.Name = "labelFirstX";
            this.labelFirstX.Size = new System.Drawing.Size(23, 13);
            this.labelFirstX.TabIndex = 4;
            this.labelFirstX.Text = "X : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Drawing lines";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.groupBoxEllipse);
            this.tabPage2.Controls.Add(this.groupBoxCircle);
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(187, 382);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "3";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Drawing a circle and an ellipse";
            // 
            // groupBoxEllipse
            // 
            this.groupBoxEllipse.Controls.Add(this.buttonDrawEllipse);
            this.groupBoxEllipse.Controls.Add(this.numericUpDownB);
            this.groupBoxEllipse.Controls.Add(this.labelB);
            this.groupBoxEllipse.Controls.Add(this.numericUpDownA);
            this.groupBoxEllipse.Controls.Add(this.labelA);
            this.groupBoxEllipse.Location = new System.Drawing.Point(19, 204);
            this.groupBoxEllipse.Margin = new System.Windows.Forms.Padding(25);
            this.groupBoxEllipse.Name = "groupBoxEllipse";
            this.groupBoxEllipse.Size = new System.Drawing.Size(148, 150);
            this.groupBoxEllipse.TabIndex = 7;
            this.groupBoxEllipse.TabStop = false;
            this.groupBoxEllipse.Text = "Ellipse";
            // 
            // buttonDrawEllipse
            // 
            this.buttonDrawEllipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDrawEllipse.Location = new System.Drawing.Point(22, 99);
            this.buttonDrawEllipse.Name = "buttonDrawEllipse";
            this.buttonDrawEllipse.Size = new System.Drawing.Size(113, 31);
            this.buttonDrawEllipse.TabIndex = 9;
            this.buttonDrawEllipse.Text = "Draw ellipse";
            this.buttonDrawEllipse.UseVisualStyleBackColor = true;
            this.buttonDrawEllipse.Click += new System.EventHandler(this.buttonDrawEllipse_Click);
            // 
            // numericUpDownB
            // 
            this.numericUpDownB.Location = new System.Drawing.Point(55, 66);
            this.numericUpDownB.Margin = new System.Windows.Forms.Padding(10);
            this.numericUpDownB.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownB.Name = "numericUpDownB";
            this.numericUpDownB.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownB.TabIndex = 2;
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(19, 68);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(23, 13);
            this.labelB.TabIndex = 5;
            this.labelB.Text = "B : ";
            // 
            // numericUpDownA
            // 
            this.numericUpDownA.Location = new System.Drawing.Point(55, 28);
            this.numericUpDownA.Margin = new System.Windows.Forms.Padding(10);
            this.numericUpDownA.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownA.Name = "numericUpDownA";
            this.numericUpDownA.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownA.TabIndex = 1;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(19, 28);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(23, 13);
            this.labelA.TabIndex = 4;
            this.labelA.Text = "A : ";
            // 
            // groupBoxCircle
            // 
            this.groupBoxCircle.Controls.Add(this.buttonDrawCircle);
            this.groupBoxCircle.Controls.Add(this.numericUpDownRadius);
            this.groupBoxCircle.Controls.Add(this.labelRadius);
            this.groupBoxCircle.Location = new System.Drawing.Point(19, 71);
            this.groupBoxCircle.Margin = new System.Windows.Forms.Padding(25);
            this.groupBoxCircle.Name = "groupBoxCircle";
            this.groupBoxCircle.Size = new System.Drawing.Size(148, 108);
            this.groupBoxCircle.TabIndex = 6;
            this.groupBoxCircle.TabStop = false;
            this.groupBoxCircle.Text = "Circle";
            // 
            // buttonDrawCircle
            // 
            this.buttonDrawCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDrawCircle.Location = new System.Drawing.Point(22, 59);
            this.buttonDrawCircle.Name = "buttonDrawCircle";
            this.buttonDrawCircle.Size = new System.Drawing.Size(113, 31);
            this.buttonDrawCircle.TabIndex = 8;
            this.buttonDrawCircle.Text = "Draw circle";
            this.buttonDrawCircle.UseVisualStyleBackColor = true;
            this.buttonDrawCircle.Click += new System.EventHandler(this.buttonDrawCircle_Click);
            // 
            // numericUpDownRadius
            // 
            this.numericUpDownRadius.Location = new System.Drawing.Point(55, 26);
            this.numericUpDownRadius.Margin = new System.Windows.Forms.Padding(10);
            this.numericUpDownRadius.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownRadius.Name = "numericUpDownRadius";
            this.numericUpDownRadius.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownRadius.TabIndex = 1;
            // 
            // labelRadius
            // 
            this.labelRadius.AutoSize = true;
            this.labelRadius.Location = new System.Drawing.Point(6, 28);
            this.labelRadius.Name = "labelRadius";
            this.labelRadius.Size = new System.Drawing.Size(49, 13);
            this.labelRadius.TabIndex = 4;
            this.labelRadius.Text = "Radius : ";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(187, 382);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "4";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 40);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(187, 382);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "5";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 40);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(187, 382);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "6";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 40);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(187, 382);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "7";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 40);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(187, 382);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "8";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 40);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(187, 382);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "9";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(4, 40);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(187, 382);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "10";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // tabPage10
            // 
            this.tabPage10.Location = new System.Drawing.Point(4, 40);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(187, 382);
            this.tabPage10.TabIndex = 9;
            this.tabPage10.Text = "11";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // tabPage11
            // 
            this.tabPage11.Location = new System.Drawing.Point(4, 40);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(187, 382);
            this.tabPage11.TabIndex = 10;
            this.tabPage11.Text = "12";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // tabPage12
            // 
            this.tabPage12.Location = new System.Drawing.Point(4, 40);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage12.Size = new System.Drawing.Size(187, 382);
            this.tabPage12.TabIndex = 11;
            this.tabPage12.Text = "13";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // tabPage13
            // 
            this.tabPage13.Location = new System.Drawing.Point(4, 40);
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage13.Size = new System.Drawing.Size(187, 382);
            this.tabPage13.TabIndex = 12;
            this.tabPage13.Text = "14";
            this.tabPage13.UseVisualStyleBackColor = true;
            // 
            // tabPage14
            // 
            this.tabPage14.Location = new System.Drawing.Point(4, 40);
            this.tabPage14.Name = "tabPage14";
            this.tabPage14.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage14.Size = new System.Drawing.Size(187, 382);
            this.tabPage14.TabIndex = 13;
            this.tabPage14.Text = "15";
            this.tabPage14.UseVisualStyleBackColor = true;
            // 
            // ComputerGraphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1116, 638);
            this.MinimumSize = new System.Drawing.Size(1116, 638);
            this.Name = "ComputerGraphics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computer graphics";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBoxSecondPoint.ResumeLayout(false);
            this.groupBoxSecondPoint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSecondY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSecondX)).EndInit();
            this.groupBoxFirstPoint.ResumeLayout(false);
            this.groupBoxFirstPoint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFirstY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFirstX)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBoxEllipse.ResumeLayout(false);
            this.groupBoxEllipse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).EndInit();
            this.groupBoxCircle.ResumeLayout(false);
            this.groupBoxCircle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRadius)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel;
        private NumericUpDown numericUpDownRadius;
        private Label labelRadius;
        private GroupBox groupBoxCircle;
        private GroupBox groupBoxEllipse;
        private NumericUpDown numericUpDownB;
        private Label labelB;
        private NumericUpDown numericUpDownA;
        private Label labelA;
        private Button buttonDrawCircle;
        private Button buttonDrawEllipse;
        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private TabPage tabPage9;
        private TabPage tabPage10;
        private TabPage tabPage11;
        private TabPage tabPage12;
        private TabPage tabPage13;
        private TabPage tabPage14;
        private Label label3;
        private Label label2;
        private GroupBox groupBoxFirstPoint;
        private NumericUpDown numericUpDownFirstY;
        private Label labelFirstY;
        private NumericUpDown numericUpDownFirstX;
        private Label labelFirstX;
        private GroupBox groupBoxSecondPoint;
        private NumericUpDown numericUpDownSecondY;
        private Label labelSecondY;
        private NumericUpDown numericUpDownSecondX;
        private Label labelSecondX;
        private Button buttonDraw;
    }
}