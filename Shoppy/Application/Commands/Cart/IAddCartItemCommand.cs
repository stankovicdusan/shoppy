﻿using Application.DataTransfer.CartDataTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.Cart
{
    public interface IAddCartItemCommand : ICommand<CartDto>
    {
    }
}
