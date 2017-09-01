
using System;
using RecyclingStation.WasteDisposal.Attributes;

namespace RecyclingStation.BussinesLogic.Attributes
{
    public class StorableStrategyAttribute : DisposableAttribute
    {
        public StorableStrategyAttribute(Type correspondingStrategyType) 
            : base(correspondingStrategyType)
        {
        }
    }
}
