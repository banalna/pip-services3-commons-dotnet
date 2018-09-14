﻿namespace PipServices.Commons.Config
{
    /// <summary>
    /// An interface to set configuration parameters to an object.
    /// 
    /// It is similar to IConfigurable interface, but emphasizes the fact
    /// that Configure() method can be called more than once to change object configuration in runtime.
    /// </summary>
    /// See <see cref="IConfigurable"/>
    public interface IReconfigurable : IConfigurable
    {
    }
}
