﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfMultilanguageByCsvSample2
{
    public class MyComboBox : ComboBox
    {
        protected override void OnItemsSourceChanged(IEnumerable oldValue, IEnumerable newValue)
        {
            base.OnItemsSourceChanged(oldValue, newValue);
            if (oldValue == null ) { return; }
            if (newValue == null) { return; }
            if (oldValue.GetType() != newValue.GetType()) { return; }            
            if (this.SelectedItem != null)
            {
                var old = SelectedItem;
                SelectedItem = null;
                SelectedItem = old;
            }
        }
    }
}
