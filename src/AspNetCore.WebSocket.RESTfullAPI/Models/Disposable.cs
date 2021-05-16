﻿using System;

namespace AspNetCore.WebSocket.RESTfullAPI
{
    public abstract class Disposable : IDisposable
    {
        /// <summary>   
        /// This is need for Dispose this object from memory.
        /// </summary>    
        public virtual void Dispose() => GC.SuppressFinalize(this);

        /// <summary>   
        /// This is Destructor for calling Dispose method.
        /// </summary>    
        ~Disposable() { Dispose(); }
    }
}
