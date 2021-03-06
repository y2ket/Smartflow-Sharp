﻿using Smartflow.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smartflow
{
    public interface IWorkflowTransitionService: IWorkflowQuery<IList<Transition>, string>, IWorkflowParse
    {
        Transition GetTransition(string id);
    }
}
