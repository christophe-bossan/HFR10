﻿using Hfr.Model;
using Hfr.Utilities;
using Hfr.ViewModel;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Hfr.Commands
{
    public class SubmitEditorCommand : Command
    {
        public override void Execute(object parameter)
        {
            Task.Run(() => Loc.Editor.SubmitEditor());
        }
    }
    
}
