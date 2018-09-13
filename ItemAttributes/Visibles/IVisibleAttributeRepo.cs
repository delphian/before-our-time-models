﻿using BeforeOurTime.Models.ItemAttributes;
using BeforeOurTime.Models.ItemAttributes.Locations;
using BeforeOurTime.Models.ItemAttributes.Physicals;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeforeOurTime.Models.ItemAttributes.Visibles
{
    /// <summary>
    /// Central data repository for all visible item attributes
    /// </summary>
    public interface IVisibleAttributeRepo : IAttributeRepo<VisibleAttribute>
    {
    }
}