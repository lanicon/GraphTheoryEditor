﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GTEditor.ViewModel;

namespace GTEditor.Model.View
{
	/// <summary>
	/// Interaction logic for SelectPanel.xaml
	/// </summary>
	public partial class SelectPanel : UserControl
	{
		public SelectPanel()
		{
			Graph gr = new OrientedGraph();
			InitializeComponent();
			SelectViewModel s = new SelectViewModel(gr);

			this.DataContext = s;
		}
	}
}
