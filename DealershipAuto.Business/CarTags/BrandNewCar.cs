﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DealershipAuto.Business;
using DealershipAuto.Business.Enums;

namespace DealershipAuto.DealershipAuto.Business.CarTags
{
	public class BrandNewCar : Car
	{
		public BrandNewCar(int id) : base(id)
		{
			CarTag = ECarTag.Standard;
		}
	}
}
