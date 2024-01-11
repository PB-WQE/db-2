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
        Me.btnShowIndividual = New System.Windows.Forms.Button()
        Me.btnShowTeam = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(756, 122)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(82, 37)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(756, 168)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(82, 37)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(756, 215)
        Me.btnDel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(82, 37)
        Me.btnDel.TabIndex = 2
        Me.btnDel.Text = "Delete"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(780, 483)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(88, 76)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(176, 127)
        Me.lblId.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(15, 13)
        Me.lblId.TabIndex = 4
        Me.lblId.Text = "id"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(194, 122)
        Me.txtId.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 5
        '
        'txtCompType
        '
        Me.txtCompType.Location = New System.Drawing.Point(194, 162)
        Me.txtCompType.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCompType.Name = "txtCompType"
        Me.txtCompType.Size = New System.Drawing.Size(100, 20)
        Me.txtCompType.TabIndex = 7
        '
        'lblCompType
        '
        Me.lblCompType.AutoSize = True
        Me.lblCompType.Location = New System.Drawing.Point(129, 165)
        Me.lblCompType.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCompType.Name = "lblCompType"
        Me.lblCompType.Size = New System.Drawing.Size(66, 13)
        Me.lblCompType.TabIndex = 6
        Me.lblCompType.Text = "Solo / Team"
        '
        'txtCompName
        '
        Me.txtCompName.Location = New System.Drawing.Point(194, 197)
        Me.txtCompName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCompName.Name = "txtCompName"
        Me.txtCompName.Size = New System.Drawing.Size(100, 20)
        Me.txtCompName.TabIndex = 9
        '
        'lblCompName
        '
        Me.lblCompName.AutoSize = True
        Me.lblCompName.Location = New System.Drawing.Point(101, 202)
        Me.lblCompName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCompName.Name = "lblCompName"
        Me.lblCompName.Size = New System.Drawing.Size(93, 13)
        Me.lblCompName.TabIndex = 8
        Me.lblCompName.Text = "Competition Name"
        '
        'txtEv1
        '
        Me.txtEv1.Location = New System.Drawing.Point(445, 123)
        Me.txtEv1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtEv1.Name = "txtEv1"
        Me.txtEv1.Size = New System.Drawing.Size(49, 20)
        Me.txtEv1.TabIndex = 11
        '
        'lblEv1
        '
        Me.lblEv1.AutoSize = True
        Me.lblEv1.Location = New System.Drawing.Point(381, 125)
        Me.lblEv1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEv1.Name = "lblEv1"
        Me.lblEv1.Size = New System.Drawing.Size(44, 13)
        Me.lblEv1.TabIndex = 10
        Me.lblEv1.Text = "Event 1"
        '
        'txtEv2
        '
        Me.txtEv2.Location = New System.Drawing.Point(445, 145)
        Me.txtEv2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtEv2.Name = "txtEv2"
        Me.txtEv2.Size = New System.Drawing.Size(49, 20)
        Me.txtEv2.TabIndex = 13
        '
        'lblEv2
        '
        Me.lblEv2.AutoSize = True
        Me.lblEv2.Location = New System.Drawing.Point(381, 148)
        Me.lblEv2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEv2.Name = "lblEv2"
        Me.lblEv2.Size = New System.Drawing.Size(44, 13)
        Me.lblEv2.TabIndex = 12
        Me.lblEv2.Text = "Event 2"
        '
        'txtEv3
        '
        Me.txtEv3.Location = New System.Drawing.Point(445, 168)
        Me.txtEv3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtEv3.Name = "txtEv3"
        Me.txtEv3.Size = New System.Drawing.Size(49, 20)
        Me.txtEv3.TabIndex = 15
        '
        'lblEv3
        '
        Me.lblEv3.AutoSize = True
        Me.lblEv3.Location = New System.Drawing.Point(381, 173)
        Me.lblEv3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEv3.Name = "lblEv3"
        Me.lblEv3.Size = New System.Drawing.Size(44, 13)
        Me.lblEv3.TabIndex = 14
        Me.lblEv3.Text = "Event 3"
        '
        'txtEv4
        '
        Me.txtEv4.Location = New System.Drawing.Point(445, 193)
        Me.txtEv4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtEv4.Name = "txtEv4"
        Me.txtEv4.Size = New System.Drawing.Size(49, 20)
        Me.txtEv4.TabIndex = 17
        '
        'lblEv4
        '
        Me.lblEv4.AutoSize = True
        Me.lblEv4.Location = New System.Drawing.Point(381, 195)
        Me.lblEv4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEv4.Name = "lblEv4"
        Me.lblEv4.Size = New System.Drawing.Size(44, 13)
        Me.lblEv4.TabIndex = 16
        Me.lblEv4.Text = "Event 4"
        '
        'txtEv5
        '
        Me.txtEv5.Location = New System.Drawing.Point(445, 215)
        Me.txtEv5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtEv5.Name = "txtEv5"
        Me.txtEv5.Size = New System.Drawing.Size(49, 20)
        Me.txtEv5.TabIndex = 19
        '
        'lblEv5
        '
        Me.lblEv5.AutoSize = True
        Me.lblEv5.Location = New System.Drawing.Point(381, 220)
        Me.lblEv5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEv5.Name = "lblEv5"
        Me.lblEv5.Size = New System.Drawing.Size(44, 13)
        Me.lblEv5.TabIndex = 18
        Me.lblEv5.Text = "Event 5"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(22, 17)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(551, 55)
        Me.lblTitle.TabIndex = 20
        Me.lblTitle.Text = "Competition details entry"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(50, 271)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(712, 262)
        Me.DataGridView1.TabIndex = 21
        '
        'btnShowIndividual
        '
        Me.btnShowIndividual.Location = New System.Drawing.Point(780, 378)
        Me.btnShowIndividual.Name = "btnShowIndividual"
        Me.btnShowIndividual.Size = New System.Drawing.Size(87, 71)
        Me.btnShowIndividual.TabIndex = 22
        Me.btnShowIndividual.Text = "Show INDIVIDUAL results"
        Me.btnShowIndividual.UseVisualStyleBackColor = True
        '
        'btnShowTeam
        '
        Me.btnShowTeam.Location = New System.Drawing.Point(780, 271)
        Me.btnShowTeam.Name = "btnShowTeam"
        Me.btnShowTeam.Size = New System.Drawing.Size(87, 71)
        Me.btnShowTeam.TabIndex = 23
        Me.btnShowTeam.Text = "Show TEAM results"
        Me.btnShowTeam.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 579)
        Me.Controls.Add(Me.btnShowTeam)
        Me.Controls.Add(Me.btnShowIndividual)
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
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
    Friend WithEvents btnShowIndividual As Button
    Friend WithEvents btnShowTeam As Button
End Class
