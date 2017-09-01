
using System;
using RecyclingStation.WasteDisposal.Attributes;

namespace RecyclingStation.BussinesLogic.Attributes
{
    public class BurnableStrategyAttribute : DisposableAttribute
    {
        public BurnableStrategyAttribute(Type correspondingStrategyType) 
            : base(correspondingStrategyType)
        {
        }
    }
}
