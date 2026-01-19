using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace heatmapgenerator
{
   [ComVisible(true)]
public class ScriptManager
{
Form2 mForm;

public ScriptManager(Form2 form)
{
mForm=form;
}
public void MethodToCallFromScript()
{
    mForm.ReDrawImage();
}
}
}

