using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agenda.Properties;
using Agenda.Constantes;
using MetroSet_UI.Controls;

namespace Agenda.Controles {

	public partial class MenuControl : UserControl {

		#region Atributos

		private bool isOpen;
		private int calculatedHeight;

		private Panel clickPanel;
		private List<MetroSetBadge> buttons;

		private bool contextMenuIsOpen = false;

		#endregion Atributos

		#region Propiedades

		public bool IsDroppedDown { get => isOpen; set => isOpen = value; }

		public string Nombre {
			get => txtName.Text.Trim().ToUpper();
			set {
				txtName.Text = value.ToUpper();
				if (Pers != null) {
					Pers.Nombre = Nombre;
				}
			}
		}

		public string NombreAnterior { get; set; }

		public IPersistenciaBD Pers { get; set; }
		public List<MetroSetBadge> Buttons { get => buttons; }

		public bool ChangingName { get => txtName.Enabled; }

		#endregion Propiedades

		#region Constructor

		public MenuControl() {
			InitializeComponent();
			Inicializar();
		}

		public MenuControl(string name, ButtonBadgeStruct[] categorias, bool newMenu = false) : this() {
			Nombre = name;
			if (!newMenu) {
				NombreAnterior = name;
			}
			CargarSubMenus(categorias);
		}

		private void Inicializar() {
			isOpen = false;
			calculatedHeight = 0;
			NombreAnterior = "";
			buttons = new List<MetroSetBadge>();

			this.BackColor = pnlName.BackgroundColor = pnlLeft.BackgroundColor = Colors.BG2;
			Size = new Size(Size.Width, MinimumSize.Height);

			// TxtName
			txtName.BackColor = Colors.BG2;
			txtName.BorderColor = Colors.BG2;
			txtName.ForeColor = Colors.Gray2;
			txtName.DisabledBackColor = Colors.BG2;
			txtName.DisabledBorderColor = Colors.BG2;
			txtName.DisabledForeColor = Colors.Gray2;
			txtName.Font = Fonts.SubTitle1;
			txtName.TabStop = false;
			txtName.Enabled = false;
			txtName.ReadOnly = false;

			// Panel Name
			pnlName.Style = MetroSet_UI.Enums.Style.Custom;
			pnlName.BackgroundColor = Colors.BG2;
			pnlName.BorderColor = Color.Transparent;
			pnlName.BorderThickness = 0;

			// Panel Left
			pnlLeft.Style = MetroSet_UI.Enums.Style.Custom;
			pnlLeft.BackgroundColor = Colors.BG2;
			pnlLeft.BorderColor = Color.Transparent;
			pnlLeft.BorderThickness = 0;

			// Arrow Down UP
			btnArrowUpDown.BorderThickness = 0;
			btnArrowUpDown.NormalColor = btnArrowUpDown.NormalBorderColor = Color.Transparent;
			btnArrowUpDown.PressColor = btnArrowUpDown.PressBorderColor = Colors.Hover1;
			btnArrowUpDown.HoverColor = btnArrowUpDown.HoverBorderColor = Colors.Hover1;
			btnArrowUpDown.Image = Resources.flecha_derecha;
			btnArrowUpDown.TabStop = false;

			// Context Menu
			contextMenu.BackColor = Colors.BG2;
			const int altura = 25;

			foreach (ToolStripMenuItem item in contextMenu.Items) {
				item.Font = Fonts.Regular(9.21f);
				item.BackColor = Colors.BG2;
				item.ForeColor = Color.WhiteSmoke;
				item.Height = altura;
				item.TextAlign = ContentAlignment.MiddleLeft;
			}

			// Click panel
			clickPanel = new Panel() {
				Name = "clickPanel",
				Location = new Point(txtName.Location.X, txtName.Location.Y - 3),
				Size = new Size(txtName.Size.Width, txtName.Size.Height + 3),
				BackColor = Color.Transparent,
				Dock = DockStyle.None,
				TabStop = false,
				Enabled = true
			};
			pnlName.Controls.Add(clickPanel);
			pnlName.Invalidate();

			div.BackColor = Colors.Gray2;

			clickPanel.MouseClick += ClickPanel_MouseClick;
			clickPanel.MouseDoubleClick += ClickPanel_MouseDoubleClick;
			clickPanel.MouseEnter += ClickPanel_MouseEnter;
			clickPanel.MouseLeave += ClickPanel_MouseLeave;
			clickPanel.MouseDown += ClickPanel_MouseDown;

			flowLay.Controls.Clear();
			flowLay.Refresh();
		}

		#endregion Constructor

		#region Events

		#region Suscribe Events

		public event EventHandler NameStartEdit;

		public event EventHandler NameEndEdit;

		public event EventHandler RemoveRequestSent;

		public event EventHandler<bool> DropDownChanged;

		#endregion Suscribe Events

		#region SubOptions Events

		private void B_MouseClick(object sender, MouseEventArgs e) {
			if (sender is MetroSetBadge b) {
			}
		}

		private void B_MouseLeave(object sender, EventArgs e) {
			if (sender is MetroSetBadge b) {
			}
		}

		private void B_MouseEnter(object sender, EventArgs e) {
			if (sender is MetroSetBadge b) {
			}
		}

		#endregion SubOptions Events

		#region Arrow Events

		private void btnArrowUpDown_MouseClick(object sender, MouseEventArgs e) {
			if (e.Clicks == 1) {
				if (e.Button == MouseButtons.Left) {
					ToggleMenu();
				} else if (e.Button == MouseButtons.Right) {
					AbrirContextMenu();
				}
			}
		}

		#endregion Arrow Events

		#region Textbox Name Events

		private void ClickPanel_MouseClick(object sender, MouseEventArgs e) {
			if (e.Clicks == 1) {
				if (e.Button == MouseButtons.Left) {
					ToggleMenu();
				} else if (e.Button == MouseButtons.Right) {
					AbrirContextMenu();
				}
			}
		}

		private void ClickPanel_MouseDoubleClick(object sender, MouseEventArgs e) {
			if (e.Clicks == 2) {
				if (e.Button == MouseButtons.Left) {
					CambiarNombre(true, e);
				}
			}
		}

		private void ClickPanel_MouseDown(object sender, MouseEventArgs e) {
			if (sender is Panel p) {
				//if (e.Button == MouseButtons.Left && e.Clicks == 1) {
				//	this.DoDragDrop(this, DragDropEffects.Move);
				//}
			}
		}

		private void ClickPanel_MouseEnter(object sender, EventArgs e) {
			Cursor = Cursors.Hand;
			pnlName.BackgroundColor = Colors.Hover3;
			txtName.DisabledBackColor = Colors.Hover3;
			txtName.DisabledBorderColor = Colors.Hover3;
			txtName.DisabledForeColor = Colors.Gray1;
		}

		private void ClickPanel_MouseLeave(object sender, EventArgs e) {
			Cursor = Cursors.Default;
			if (!contextMenuIsOpen) {
				pnlName.BackgroundColor = Colors.BG2;
				txtName.DisabledBackColor = Colors.BG2;
				txtName.DisabledBorderColor = Colors.BG2;
				txtName.DisabledForeColor = Colors.Gray2;
			}
		}

		private void txtName_KeyPress(object sender, KeyPressEventArgs e) {
			if (e.KeyChar == (char)13) {
				// Enter key pressed
				CambiarNombre(false);
			}
		}

		private void txtName_Validating(object sender, CancelEventArgs e) {
			CambiarNombre(false, e);
		}

		private void txtName_TextChanged(object sender, EventArgs e) {
			Nombre = txtName.Text.ToUpper();
			txtName.Select(txtName.Text.Length, 0);
		}

		#endregion Textbox Name Events

		#region Context Menu

		private void cambiarNombreToolStripMenuItem_Click_1(object sender, EventArgs e) {
			CambiarNombre(true, e);
		}

		private void eliminarToolStripMenuItem_Click_1(object sender, EventArgs e) {
			this.RemoveRequestSent?.Invoke(this, e);
		}

		private void configurarMáximoToolStripMenuItem_Click(object sender, EventArgs e) {
		}

		#endregion Context Menu

		#endregion Events

		#region Publicas

		public void MostrarError(string texto) {
			errorProvider.SetError(txtName, texto);
		}

		public void ToggleMenu() {
			CambiarNombre(false, null);
			if (!isOpen) {
				btnArrowUpDown.Image = Resources.flecha_abajo;
				txtName.ForeColor = Color.White;
				txtName.DisabledForeColor = Color.White;
				txtName.Refresh();
				Size = new Size(Size.Width, calculatedHeight);
			} else {
				btnArrowUpDown.Image = Resources.flecha_derecha;
				txtName.ForeColor = Colors.Gray1;
				txtName.DisabledForeColor = Colors.Gray1;
				txtName.Refresh();
				Size = new Size(Size.Width, MinimumSize.Height);
			}
			isOpen = !isOpen;
			this.DropDownChanged?.Invoke(this, isOpen);
			errorProvider.Clear();
			Application.DoEvents();
		}

		public void CambiarNombre(bool activate, EventArgs e = null) {
			if (ChangingName != activate) {
				txtName.Enabled = activate;
				clickPanel.Enabled = !activate;
				if (activate) {
					errorProvider.Clear();
					txtName.BackColor = Colors.BG2;
					txtName.ForeColor = Colors.Gray1;
					//NombreAnterior = Nombre;
					txtName.Focus();
					txtName.SelectAll();
					this.NameStartEdit?.Invoke(this, e);
				} else {
					if (Nombre != NombreAnterior) {
						this.NameEndEdit?.Invoke(this, e);
					}
				}
			}
		}

		#endregion Publicas

		#region Privadas

		private void AbrirContextMenu() {
			contextMenuIsOpen = true;
			pnlName.BackgroundColor = Colors.Hover2;
			txtName.BackColor = Colors.Hover2;
			txtName.DisabledBackColor = Colors.Hover2;
			txtName.DisabledBorderColor = Colors.Hover2;
			contextMenu.Show(this, Width, 0);
		}

		private void contextMenu_Closed(object sender, ToolStripDropDownClosedEventArgs e) {
			contextMenuIsOpen = false;
			pnlName.BackgroundColor = Colors.BG2;
			txtName.BackColor = Colors.BG2;
			txtName.DisabledBackColor = Colors.BG2;
			txtName.DisabledBorderColor = Colors.BG2;
		}

		private void CargarSubMenus(ButtonBadgeStruct[] menus) {
			flowLay.Controls.Clear();
			buttons.Clear();
			int jeigt = pnlName.Height + flowLay.Padding.Top + flowLay.Padding.Bottom + 5;

			var btnSize = new Size(this.Width - pnlLeft.Width - 70, 44);
			int btnsHeight = 0;
			foreach (var cat in menus) {
				MetroSetBadge b = new MetroSetBadge {
					Name = $"btn{cat.Nombre.Replace(" ", "")}",
					Text = cat.Nombre,
					Font = new Font(Fonts.Text1, FontStyle.Bold),
					NormalColor = Color.Transparent,
					NormalTextColor = Colors.Gray1,
					NormalBorderColor = Color.Transparent,
					NormalBadgeColor = Colors.BG3,
					NormalBadgeTextColor = Colors.Gray1,
					HoverColor = Colors.Hover1,
					HoverTextColor = Color.White,
					HoverBorderColor = Color.Transparent,
					HoverBadgeColor = Colors.BG3,
					HoverBadgeTextColor = Colors.Gray1,
					PressColor = Colors.Hover1,
					PressTextColor = Color.White,
					PressBorderColor = Color.Transparent,
					PressBadgeColor = Colors.Gray1,
					PressBadgeTextColor = Color.White,
					BadgeText = cat.BadgeText,
					Cursor = Cursors.Hand,
					Size = btnSize,
					TabStop = false
				};
				btnsHeight += b.Height + 5;

				flowLay.Controls.Add(b);
				buttons.Add(b);

				b.MouseEnter += B_MouseEnter;
				b.MouseLeave += B_MouseLeave;
				b.MouseClick += B_MouseClick;

				var line = new MetroSetDivider() {
					Orientation = MetroSet_UI.Enums.DividerStyle.Horizontal,
					Thickness = 2,
					Style = MetroSet_UI.Enums.Style.Custom,
					ForeColor = Colors.Gray2,
					Location = new Point(div.Location.X, btnsHeight - 17),
					Size = new Size(17, 4),
					TabStop = false,
				};
				line.BringToFront();
				pnlLeft.Controls.Add(line);
			}
			calculatedHeight = jeigt + btnsHeight;

			flowLay.Refresh();
		}

		#endregion Privadas

		#region Override

		public override string ToString() {
			return $"{Nombre} - ({(ChangingName ? "Renaming" : (isOpen ? "Dropped Down" : "Minimized"))}) - Pers: {Pers != null}";
		}

		#endregion Override
	}

	#region Interface Persistencia

	public interface IPersistenciaBD {

		#region Properties

		int Codigo { get; set; }

		string Nombre { get; set; }

		#endregion Properties

		#region Methods

		bool Existe();

		bool Agregar();

		bool Modificar();

		bool Eliminar();

		bool RecuperarLogico();

		bool ExisteLogico();

		#endregion Methods
	}

	#endregion Interface Persistencia

	public struct ButtonBadgeStruct {
		public string Nombre { get; set; }
		public string BadgeText { get; set; }

		public ButtonBadgeStruct(string nombre, string cantidad) : this() {
			Nombre = nombre;
			BadgeText = cantidad;
		}
	}
}