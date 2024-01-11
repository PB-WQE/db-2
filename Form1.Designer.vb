<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblId = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtCompType = New System.Windows.Forms.TextBox()
        Me.lblCompType = New System.Windows.Forms.Label()
        Me.txtCompName = New System.Windows.Forms.TextBox()
        Me.lblCompName = New System.Windows.Forms.Label()
        Me.txtEv1 = New System.Windows.Forms.TextBox()
        Me.lblEv1 = New System.Windows.Forms.Label()
        Me.txtEv2 = New System.Windows.Forms.TextBox()
        Me.lblEv2 = New System.Windows.Forms.Label()
        Me.txtEv3 = New System.Windows.Forms.TextBox()
        Me.lblEv3 = New System.Windows.Forms.Label()
        Me.txtEv4 = New System.Windows.Forms.TextBox()
        Me.lblEv4 = New System.Windows.Forms.Label()
        Me.txtEv5 = New System.Windows.Forms.TextBox()
        Me.lblEv5 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(1008, 150)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(109, 45)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(1008, 207)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(109, 45)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(1008, 265)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(109, 45)
        Me.btnDel.TabIndex = 2
        Me.btnDel.Text = "Delete"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(1040, 594)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(117, 93)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(235, 156)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(18, 16)
        Me.lblId.TabIndex = 4
        Me.lblId.Text = "id"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(259, 150)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(132, 22)
        Me.txtId.TabIndex = 5
        '
        'txtCompType
        '
        Me.txtCompType.Location = New System.Drawing.Point(259, 200)
        Me.txtCompType.Name = "txtCompType"
        Me.txtCompType.Size = New System.Drawing.Size(132, 22)
        Me.txtCompType.TabIndex = 7
        '
        'lblCompType
        '
        Me.lblCompType.AutoSize = True
        Me.lblCompType.Location = New System.Drawing.Point(172, 203)
        Me.lblCompType.Name = "lblCompType"
        Me.lblCompType.Size = New System.Drawing.Size(81, 16)
        Me.lblCompType.TabIndex = 6
        Me.lblCompType.Text = "Solo / Team"
        '
        'txtCompName
        '
        Me.txtCompName.Location = New System.Drawing.Point(259, 242)
        Me.txtCompName.Name = "txtCompName"
        Me.txtCompName.Size = New System.Drawing.Size(132, 22)
        Me.txtCompName.TabIndex = 9
        '
        'lblCompName
        '
        Me.lblCompName.AutoSize = True
        Me.lblCompName.Location = New System.Drawing.Point(135, 248)
        Me.lblCompName.Name = "lblCompName"
        Me.lblCompName.Size = New System.Drawing.Size(118, 16)
        Me.lblCompName.TabIndex = 8
        Me.lblCompName.Text = "Competition Name"
        '
        'txtEv1
        '
        Me.txtEv1.Location = New System.Drawing.Point(593, 151)
        Me.txtEv1.Name = "txtEv1"
        Me.txtEv1.Size = New System.Drawing.Size(64, 22)
        Me.txtEv1.TabIndex = 11
        '
        'lblEv1
        '
        Me.lblEv1.AutoSize = True
        Me.lblEv1.Location = New System.Drawing.Point(508, 154)
        Me.lblEv1.Name = "lblEv1"
        Me.lblEv1.Size = New System.Drawing.Size(51, 16)
        Me.lblEv1.TabIndex = 10
        Me.lblEv1.Text = "Event 1"
        '
        'txtEv2
        '
        Me.txtEv2.Location = New System.Drawing.Point(593, 179)
        Me.txtEv2.Name = "txtEv2"
        Me.txtEv2.Size = New System.Drawing.Size(64, 22)
        Me.txtEv2.TabIndex = 13
        '
        'lblEv2
        '
        Me.lblEv2.AutoSize = True
        Me.lblEv2.Location = New System.Drawing.Point(508, 182)
        Me.lblEv2.Name = "lblEv2"
        Me.lblEv2.Size = New System.Drawing.Size(51, 16)
        Me.lblEv2.TabIndex = 12
        Me.lblEv2.Text = "Event 2"
        '
        'txtEv3
        '
        Me.txtEv3.Location = New System.Drawing.Point(593, 207)
        Me.txtEv3.Name = "txtEv3"
        Me.txtEv3.Size = New System.Drawing.Size(64, 22)
        Me.txtEv3.TabIndex = 15
        '
        'lblEv3
        '
        Me.lblEv3.AutoSize = True
        Me.lblEv3.Location = New System.Drawing.Point(508, 213)
        Me.lblEv3.Name = "lblEv3"
        Me.lblEv3.Size = New System.Drawing.Size(51, 16)
        Me.lblEv3.TabIndex = 14
        Me.lblEv3.Text = "Event 3"
        '
        'txtEv4
        '
        Me.txtEv4.Location = New System.Drawing.Point(593, 237)
        Me.txtEv4.Name = "txtEv4"
        Me.txtEv4.Size = New System.Drawing.Size(64, 22)
        Me.txtEv4.TabIndex = 17
        '
        'lblEv4
        '
        Me.lblEv4.AutoSize = True
        Me.lblEv4.Location = New System.Drawing.Point(508, 240)
        Me.lblEv4.Name = "lblEv4"
        Me.lblEv4.Size = New System.Drawing.Size(51, 16)
        Me.lblEv4.TabIndex = 16
        Me.lblEv4.Text = "Event 4"
        '
        'txtEv5
        '
        Me.txtEv5.Location = New System.Drawing.Point(593, 265)
        Me.txtEv5.Name = "txtEv5"
        Me.txtEv5.Size = New System.Drawing.Size(64, 22)
        Me.txtEv5.TabIndex = 19
        '
        'lblEv5
        '
        Me.lblEv5.AutoSize = True
        Me.lblEv5.Location = New System.Drawing.Point(508, 271)
        Me.lblEv5.Name = "lblEv5"
        Me.lblEv5.Size = New System.Drawing.Size(51, 16)
        Me.lblEv5.TabIndex = 18
        Me.lblEv5.Text = "Event 5"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(29, 21)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(689, 69)
        Me.lblTitle.TabIndex = 20
        Me.lblTitle.Text = "Competition details entry"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(66, 334)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(950, 323)
        Me.DataGridView1.TabIndex = 21
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1182, 713)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtEv5)
        Me.Controls.Add(Me.lblEv5)
        Me.Controls.Add(Me.txtEv4)
        Me.Controls.Add(Me.lblEv4)
        Me.Controls.Add(Me.txtEv3)
        Me.Controls.Add(Me.lblEv3)
        Me.Controls.Add(Me.txtEv2)
        Me.Controls.Add(Me.lblEv2)
        Me.Controls.Add(Me.txtEv1)
        Me.Controls.Add(Me.lblEv1)
        Me.Controls.Add(Me.txtCompName)
        Me.Controls.Add(Me.lblCompName)
        Me.Controls.Add(Me.txtCompType)
        Me.Controls.Add(Me.lblCompType)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "Form1"
        Me.Text = "Form 1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblId As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtCompType As TextBox
    Friend WithEvents lblCompType As Label
    Friend WithEvents txtCompName As TextBox
    Friend WithEvents lblCompName As Label
    Friend WithEvents txtEv1 As TextBox
    Friend WithEvents lblEv1 As Label
    Friend WithEvents txtEv2 As TextBox
    Friend WithEvents lblEv2 As Label
    Friend WithEvents txtEv3 As TextBox
    Friend WithEvents lblEv3 As Label
    Friend WithEvents txtEv4 As TextBox
    Friend WithEvents lblEv4 As Label
    Friend WithEvents txtEv5 As TextBox
    Friend WithEvents lblEv5 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
