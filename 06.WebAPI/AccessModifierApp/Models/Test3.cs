﻿namespace AccessModifierApp.Models;
internal class Test3
{
    public string PublicProperty { get; set; }
    internal string InternalProperty { get; set; }
    private string PrivateProperty { get; set; }
    protected string ProtectedProperty { get; set; }
}