﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan147.Estore.SqlDataLayer.Dtos
{
	public class CommonDto
	{
        public int CommonID { get; set; }
        public string CommonName { get; set; }
        public DateTime CommonTime { get; set; }
        public string  CommonContext { get; set; }
        public int ThemeID { get; set; }

    }
}
