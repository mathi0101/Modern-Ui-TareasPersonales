using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Agenda.Controles {

	public partial class CircularLabel : Label {

		public CircularLabel() {
			InitializeComponent();
		}

		public CircularLabel(IContainer container) {
			container.Add(this);

			InitializeComponent();
		}
	}
}