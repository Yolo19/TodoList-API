﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList.GraphQL.Users
{
    public record EditUserInput(
        string? Name,
        //string? Password);
        //string GitHub,
        string? ImageURI);
}
