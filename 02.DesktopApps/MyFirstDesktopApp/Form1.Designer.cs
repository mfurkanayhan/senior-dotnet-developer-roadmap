namespace MyFirstDesktopApp;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new Label();
        txtWork = new TextBox();
        btnSave = new Button();
        lstTodos = new ListBox();
        btnUpdate = new Button();
        btnCancel = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(86, 23);
        label1.Name = "label1";
        label1.Size = new Size(81, 15);
        label1.TabIndex = 0;
        label1.Text = "A Job of Work";
        // 
        // txtWork
        // 
        txtWork.Location = new Point(43, 66);
        txtWork.Name = "txtWork";
        txtWork.Size = new Size(172, 23);
        txtWork.TabIndex = 1;
        // 
        // btnSave
        // 
        btnSave.Location = new Point(43, 95);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(172, 40);
        btnSave.TabIndex = 2;
        btnSave.Text = "Kaydet";
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Click += btnSave_Click;
        // 
        // lstTodos
        // 
        lstTodos.DisplayMember = "Furkan";
        lstTodos.FormattingEnabled = true;
        lstTodos.ItemHeight = 15;
        lstTodos.Items.AddRange(new object[] { "John", "Jane", "Clara", "Barbara" });
        lstTodos.Location = new Point(43, 141);
        lstTodos.Name = "lstTodos";
        lstTodos.Size = new Size(172, 229);
        lstTodos.TabIndex = 3;
        lstTodos.MouseClick += lstTodos_MouseClick;
        lstTodos.MouseDoubleClick += lstTodos_MouseDoubleClick;
        // 
        // btnUpdate
        // 
        btnUpdate.Location = new Point(43, 95);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(172, 40);
        btnUpdate.TabIndex = 4;
        btnUpdate.Text = "Update";
        btnUpdate.UseVisualStyleBackColor = true;
        btnUpdate.Click += btnUpdate_Click;
        // 
        // btnCancel
        // 
        btnCancel.Location = new Point(43, 141);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(172, 40);
        btnCancel.TabIndex = 5;
        btnCancel.Text = "Cancel";
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.Click += btnCancel_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(256, 400);
        Controls.Add(btnCancel);
        Controls.Add(btnUpdate);
        Controls.Add(lstTodos);
        Controls.Add(btnSave);
        Controls.Add(txtWork);
        Controls.Add(label1);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Todo App";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox txtWork;
    private Button btnSave;
    private ListBox lstTodos;
    private Button btnUpdate;
    private Button btnCancel;
}
