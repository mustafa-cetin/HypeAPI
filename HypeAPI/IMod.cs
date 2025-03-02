using System;
using System.Collections.Generic;
using System.Text;

namespace HypeAPI
{
    public interface IMod
    {
        public bool Enabled { get; set; }
        void OnEnable();
        void OnDisable();
        public void Initialize(ModAPI modApi);
    }
}
