﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ultimate_RenPy_Decompiler
{
    public partial class RPADECOMPILER : UserControl
    {



        private string pathtogame;

        public RPADECOMPILER()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void DEC_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(pathtogame)) 
            {
                File.Create(pathtogame + "\\un.rpy").Close();
                if (File.Exists(pathtogame + "\\un.rpy"))
                {
                    File.WriteAllText(pathtogame + "\\un.rpy", "\r\ninit python early hide:\r\n\r\n    import sys\r\n    renpy_modules = sys.modules.copy()\r\n    renpy_meta_path = sys.meta_path.copy()\r\n\r\n    # Set up the namespace\r\n    import os\r\n    import os.path\r\n    import renpy\r\n    import renpy.loader\r\n    import base64\r\n    import pickle\r\n    import zlib\r\n    import pathlib\r\n\r\n    basepath = os.path.join(os.getcwd(), \"game\")\r\n    files = renpy.loader.listdirfiles()\r\n\r\n    sys.files = []\r\n    for (dir, fn) in files:\r\n        if fn.endswith((\".rpyc\", \".rpymc\")):\r\n            if dir and dir.endswith(\"common\"):\r\n                continue\r\n            elif fn == \"un.rpyc\":\r\n                continue\r\n            elif (dir, fn[:-1]) not in files:\r\n                abspath = os.path.join(dir, fn) if dir else os.path.join(basepath, fn)\r\n                with renpy.loader.load(fn) as file:\r\n                    bindata = renpy.game.script.read_rpyc_data(file, 1)\r\n                    sys.files.append((pathlib.Path(abspath), bindata))\r\n\r\n    for i in renpy_modules:\r\n        if \"renpy\" in i and not \"renpy.execution\" in i:\r\n            sys.modules.pop(i)\r\n    sys.meta_path[:] = [i for i in sys.meta_path if \"renpy\" not in i.__class__.__module__]\r\n\r\n    # ?????????\r\n    unrpyc = pickle.loads(base64.b64decode(b'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'))\r\n    unrpyc.decompile_game()\r\n\r\n    from decompiler.magic import remove_fake_package\r\n    remove_fake_package(\"renpy\")\r\n\r\n    sys.modules.clear()\r\n    sys.modules.update(renpy_modules)\r\n    sys.meta_path[:] = renpy_meta_path\r\n");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void CHS_FILE_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string selectedPath = dialog.SelectedPath;
                    pathtogame = selectedPath;
                    TXT_FILE.Text = selectedPath;
                }
            }
        }
    }
}
