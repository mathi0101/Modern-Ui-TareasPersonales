using Agenda.Constantes;
using Agenda.Controles;
using MetroSet_UI.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GMAgendaPersonal.Clases {

	internal class SlideMenuController {
		internal static readonly string[] DEFAULT_NAMES_TO_REMOVE = new string[] { "<RENOMBRAR>", "", " " };

		#region Atributos

		private Form mainForm;
		private Panel mainPanel;
		private FlowLayoutPanel flowLayout;
		private Label titleLabel;
		private MetroSetEllipse addButton;
		private Timer timer;
		private PictureBox dot_picture;

		private bool _expanded;

		private List<MenuPreset> menuPresets = new List<MenuPreset>();
		private MenuPreset currentPresetShowing = null;

		#endregion Atributos

		#region Properties

		public bool IsExpanded { get => _expanded; }

		private bool HasMenus { get => menuPresets.Count > 0; }
		public MenuPreset CurrentPresetShowing { get => currentPresetShowing; }

		#endregion Properties

		#region Constructor

		public SlideMenuController(Timer _timer, PictureBox _dot_picture, Form _mainForm, Panel _mainPanel, FlowLayoutPanel _contentFlow, Label _titleLabel, MetroSetEllipse _addButton) {
			this.timer = _timer;
			this.dot_picture = _dot_picture;
			this.mainPanel = _mainPanel;
			this.flowLayout = _contentFlow;
			this.titleLabel = _titleLabel;
			this.addButton = _addButton;
			this.mainForm = _mainForm;

			this.timer.Tick += Timer_Tick;
			this.addButton.MouseClick += AddButton_MouseClick;
			this.flowLayout.MouseClick += UserInteraction_MouseClick;
			this.titleLabel.MouseClick += UserInteraction_MouseClick;

			titleLabel.Font = Fonts.Title1;
			titleLabel.ForeColor = Color.White;

			flowLayout.HorizontalScroll.Enabled = false;
			flowLayout.VerticalScroll.LargeChange = 3;
			flowLayout.VerticalScroll.SmallChange = 1;
			flowLayout.MinimumSize = new Size(flowLayout.Width + 20, 0);
			// le sumamos 20 al tamaño para que no se vea el vertical scroll bar
		}

		#endregion Constructor

		#region Events

		#region Timer Tick

		private void Timer_Tick(object sender, EventArgs e) {
			const int increment = 15;
			if (_expanded) {
				mainPanel.Width -= increment;
				if (mainPanel.Width <= mainPanel.MinimumSize.Width) {
					_expanded = false;
					dot_picture.Visible = false;
					timer.Stop();
					if (currentPresetShowing != null) {
						foreach (var cat in currentPresetShowing.Categorias) {
							if (cat.IsDroppedDown) {
								cat.ToggleMenu();
							}
						}
					}
				}
			} else {
				dot_picture.Visible = true;
				mainPanel.Width += increment;
				if (mainPanel.Width >= mainPanel.MaximumSize.Width) {
					_expanded = true;
					timer.Stop();
				}
			}
		}

		#endregion Timer Tick

		#region User Interaction

		public void UserInteraction_MouseClick(object sender, MouseEventArgs e) {
			CerrarCambioDeNombre();
		}

		#endregion User Interaction

		#region Add Button

		private void AddButton_MouseClick(object sender, MouseEventArgs e) {
			if (currentPresetShowing != null && sender is MetroSetEllipse b) {
				if (e.Button == MouseButtons.Left && e.Clicks == 1) {
					CerrarCambioDeNombre();
					NuevoMenu(currentPresetShowing.Id, 0);
				}
			}
		}

		#endregion Add Button

		#region Menu Control Events

		private void M_NameEndEdit(object sender, EventArgs e) {
			if (sender is MenuControl m) {
				var obj = currentPresetShowing;
				mainForm.UseWaitCursor = true;
				if (m.Pers != null) {
					if (m.Pers.Codigo != 0 && m.Pers.Existe()) {
						// Es un menu cargado de la base
						if (DEFAULT_NAMES_TO_REMOVE.Contains(m.Nombre)) {
							// Nombre no habilitado
							if (m.Pers.Eliminar()) {
								QuitarMenu(obj, m);
							}
						} else {
							if (m.Nombre != m.NombreAnterior) {
								if (!m.Pers.ExisteLogico()) {
									if (!m.Pers.Modificar()) {
										m.Nombre = m.NombreAnterior;
										m.MostrarError("No se ha podido guardar en el servidor!");
									} else {
										m.NombreAnterior = m.Nombre;
									}
								} else {
									m.MostrarError($"Ya hay una categoria llamada '{m.Nombre}'!");
									m.Nombre = m.NombreAnterior;
								}
							}
						}
					} else {
						if (!DEFAULT_NAMES_TO_REMOVE.Contains(m.Nombre)) {
							if (!m.Pers.ExisteLogico()) {
								// Si no existe la categoria con este nombre para este usuario
								if (!m.Pers.Agregar() & !m.Pers.RecuperarLogico()) {
									QuitarMenu(obj, m);
								} else {
									m.NombreAnterior = m.Nombre;
								}
							} else {
								QuitarMenu(obj, m);
							}
						} else {
							QuitarMenu(obj, m);
						}
					}
				}
				mainForm.UseWaitCursor = false;
			}
		}

		private void M_RemoveRequestSent(object sender, EventArgs e) {
			if (sender is MenuControl m) {
				if (m.Pers != null) {
					if (m.Pers.Eliminar()) {
						QuitarMenu(currentPresetShowing, m);
					}
				}
			}
		}

		#endregion Menu Control Events

		#endregion Events

		#region Publicas

		public void CargarPresets(MenuPreset[] menus, bool cleanB4 = false) {
			if (cleanB4) {
				LimpiarTodo();
			}
			foreach (var menu in menus) {
				if (menuPresets.Where(x => x.Id == menu.Id).Count() == 0) {
					menuPresets.Add(menu);
				}
			}
		}

		public void CloseMenu() {
			if (_expanded) {
				timer.Start();
				while (timer.Enabled) {
					// wait until is closed
					Application.DoEvents();
				}
			}
		}

		public void ToggleMenu(uint menuId, Control btn) {
			if (HasMenus) {
				MenuPreset menu = menuPresets.Find(x => x.Id == menuId);

				if (menu != null && !timer.Enabled) {
					var btnMiddlePoint = GetCenterPointLocation(btn);
					dot_picture.Location = new Point(dot_picture.Location.X, btnMiddlePoint.Y - dot_picture.Size.Height / 2);

					if (currentPresetShowing?.Id != menuId) {
						CloseMenu();
						LoadMenu(menu);
					}
					timer.Start();
				}
			}
		}

		public void QuitarMenu(MenuPreset menu, MenuControl control) {
			if (menu != null) {
				menu.Categorias.Remove(control);
				control.Dispose();
				LoadMenu(menu);
			}
		}

		public void Dispose() {
			LimpiarTodo();
			flowLayout.Dispose();
		}

		#endregion Publicas

		#region Privadas

		private void CerrarCambioDeNombre() {
			try {
				if (HasMenus && currentPresetShowing != null) {
					foreach (MenuControl ctrl in currentPresetShowing.Categorias) {
						if (ctrl.ChangingName) {
							ctrl.CambiarNombre(false, null);
						}
					}
				}
			} catch (InvalidOperationException) {
			}
		}

		private void NuevoMenu(uint menuID, int index) {
			var control = new MenuControl(DEFAULT_NAMES_TO_REMOVE.First(), new ButtonBadgeStruct[] { new ButtonBadgeStruct("Todas", "0") }, true);

			MenuPreset menu = menuPresets.Find(x => x.Id == menuID);
			if (menu != null) {
				control.Pers = menu.NewItemsPersistencia();
				control.Anchor = AnchorStyles.None;
				menu.Categorias.Insert(index, control);
				LoadMenu(menu);

				control.CambiarNombre(true);
			}
		}

		private void LoadMenu(MenuPreset menu) {
			titleLabel.Text = menu.VisibleName;
			addButton.Enabled = menu.NewItemsPersistencia != null;

			flowLayout.Controls.Clear();
			foreach (var m in menu.Categorias) {
				m.Size = new Size(flowLayout.Width - 25, m.Height);
				flowLayout.Controls.Add(m);
				m.NameEndEdit += M_NameEndEdit;
				m.RemoveRequestSent += M_RemoveRequestSent;
				m.DropDownChanged += M_DropDownChanged;
			}
			flowLayout.Refresh();
			currentPresetShowing = menu;
		}

		private void M_DropDownChanged(object sender, bool e) {
			if (e) {
				UserInteraction_MouseClick(null, null);
			}
		}

		private Point GetCenterPointLocation(Control control) {
			Point p = control.Location;
			p.X += control.Size.Width / 2;
			p.Y += control.Size.Height / 2;

			return p;
		}

		private void LimpiarTodo() {
			CloseMenu();
			foreach (var m in menuPresets) {
				foreach (var cat in m.Categorias) {
					cat.Dispose();
				}
			}
			menuPresets.Clear();
			currentPresetShowing = null;

			flowLayout.Controls.Clear();
			flowLayout.Refresh();
		}

		#endregion Privadas
	}

	#region Clases Aux

	internal class MenuPreset {

		#region Atributos

		private readonly uint id;
		private readonly string visibleName;
		private List<MenuControl> categorias;

		#endregion Atributos

		public uint Id { get => id; }
		public string VisibleName { get => visibleName; }
		public List<MenuControl> Categorias { get => categorias; }
		public Func<IPersistenciaBD> NewItemsPersistencia { get; set; }

		#region Constructor

		public MenuPreset(uint codigo_Menu, string visibleName) {
			this.id = codigo_Menu;
			this.visibleName = visibleName;
			this.categorias = new List<MenuControl>();
		}

		#endregion Constructor

		#region ToString

		public override string ToString() {
			return $"{id}: {VisibleName} - {categorias.Count()} sub menus";
		}

		#endregion ToString

		#region Cargar Controles

		public void CargarMenus(List<MenuControl> controles) {
			categorias.AddRange(controles);
		}

		#endregion Cargar Controles
	}

	#endregion Clases Aux
}