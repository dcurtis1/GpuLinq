﻿
namespace LinqOptimizer.Core

open System.Reflection
open System.Runtime.CompilerServices
open System.Runtime.InteropServices
 
module Version =
    let [<Literal>]Number = "0.3.1.*"

[<assembly: AssemblyVersion(Version.Number)>]
do ()