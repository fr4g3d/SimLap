﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetting))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbUPassDB = New System.Windows.Forms.TextBox()
        Me.tbUDBName = New System.Windows.Forms.TextBox()
        Me.tbDBName = New System.Windows.Forms.TextBox()
        Me.tbPort = New System.Windows.Forms.TextBox()
        Me.tbHostName = New System.Windows.Forms.TextBox()
        Me.btnSaveSetting = New System.Windows.Forms.Button()
        Me.btnReloadSetting = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.tbUPassDB, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.tbUDBName, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.tbDBName, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tbPort, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tbHostName, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(9, 10)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(310, 126)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Host Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Port"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 50)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Database Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(2, 75)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "User Name DB"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(2, 100)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 26)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "User Pass DB"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(90, 0)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = ":"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(90, 25)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = ":"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(90, 50)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(10, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = ":"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(90, 75)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(10, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = ":"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(90, 100)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(10, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = ":"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbUPassDB
        '
        Me.tbUPassDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.tbUPassDB.Location = New System.Drawing.Point(106, 102)
        Me.tbUPassDB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbUPassDB.Name = "tbUPassDB"
        Me.tbUPassDB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.tbUPassDB.Size = New System.Drawing.Size(200, 20)
        Me.tbUPassDB.TabIndex = 15
        '
        'tbUDBName
        '
        Me.tbUDBName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.tbUDBName.Location = New System.Drawing.Point(106, 77)
        Me.tbUDBName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbUDBName.Name = "tbUDBName"
        Me.tbUDBName.Size = New System.Drawing.Size(200, 20)
        Me.tbUDBName.TabIndex = 14
        '
        'tbDBName
        '
        Me.tbDBName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.tbDBName.Location = New System.Drawing.Point(106, 52)
        Me.tbDBName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbDBName.Name = "tbDBName"
        Me.tbDBName.Size = New System.Drawing.Size(200, 20)
        Me.tbDBName.TabIndex = 13
        '
        'tbPort
        '
        Me.tbPort.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.tbPort.Location = New System.Drawing.Point(106, 27)
        Me.tbPort.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbPort.Name = "tbPort"
        Me.tbPort.Size = New System.Drawing.Size(200, 20)
        Me.tbPort.TabIndex = 12
        '
        'tbHostName
        '
        Me.tbHostName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.tbHostName.Location = New System.Drawing.Point(106, 2)
        Me.tbHostName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbHostName.Name = "tbHostName"
        Me.tbHostName.Size = New System.Drawing.Size(200, 20)
        Me.tbHostName.TabIndex = 11
        '
        'btnSaveSetting
        '
        Me.btnSaveSetting.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSaveSetting.Location = New System.Drawing.Point(9, 145)
        Me.btnSaveSetting.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSaveSetting.Name = "btnSaveSetting"
        Me.btnSaveSetting.Size = New System.Drawing.Size(56, 19)
        Me.btnSaveSetting.TabIndex = 1
        Me.btnSaveSetting.Text = "&Save"
        Me.btnSaveSetting.UseVisualStyleBackColor = True
        '
        'btnReloadSetting
        '
        Me.btnReloadSetting.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReloadSetting.Location = New System.Drawing.Point(262, 145)
        Me.btnReloadSetting.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnReloadSetting.Name = "btnReloadSetting"
        Me.btnReloadSetting.Size = New System.Drawing.Size(56, 19)
        Me.btnReloadSetting.TabIndex = 2
        Me.btnReloadSetting.Text = "&ReLoad"
        Me.btnReloadSetting.UseVisualStyleBackColor = True
        '
        'frmSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 174)
        Me.Controls.Add(Me.btnReloadSetting)
        Me.Controls.Add(Me.btnSaveSetting)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSetting"
        Me.Opacity = 0.85R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Setting"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents tbUPassDB As TextBox
    Friend WithEvents tbUDBName As TextBox
    Friend WithEvents tbDBName As TextBox
    Friend WithEvents tbPort As TextBox
    Friend WithEvents tbHostName As TextBox
    Friend WithEvents btnSaveSetting As Button
    Friend WithEvents btnReloadSetting As Button
End Class
