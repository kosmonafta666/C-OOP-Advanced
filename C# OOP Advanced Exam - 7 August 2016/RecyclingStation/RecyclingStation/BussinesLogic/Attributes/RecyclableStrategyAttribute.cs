
using System;
using RecyclingStation.WasteDisposal.Attributes;

namespace RecyclingStation.BussinesLogic.Attributes
{
    public class RecyclableStrategyAttribute : DisposableAttribute
    {
        public RecyclableStrategyAttribute(Type correspondingStrategyType) 
            : base(correspondingStrategyType)
        {
        }
    }
}
