//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998

namespace DeviceInterfaces
{
    using System;
    using System.Net;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.IO;
    using System.Collections.Generic;
    using Orleans;
    using Orleans.Runtime;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class DeviceGrainFactory
    {
        

                        public static DeviceInterfaces.IDeviceGrain GetGrain(long primaryKey, string keyExt)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeKeyExtendedGrainReferenceInternal(typeof(DeviceInterfaces.IDeviceGrain), -354462699, primaryKey, keyExt));
                        }

                        public static DeviceInterfaces.IDeviceGrain GetGrain(long primaryKey, string keyExt, string grainClassNamePrefix)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeKeyExtendedGrainReferenceInternal(typeof(DeviceInterfaces.IDeviceGrain), -354462699, primaryKey, keyExt, grainClassNamePrefix));
                        }

                        public static DeviceInterfaces.IDeviceGrain GetGrain(System.Guid primaryKey, string keyExt)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeKeyExtendedGrainReferenceInternal(typeof(DeviceInterfaces.IDeviceGrain), -354462699, primaryKey, keyExt));
                        }

                        public static DeviceInterfaces.IDeviceGrain GetGrain(System.Guid primaryKey, string keyExt, string grainClassNamePrefix)
                        {
                            return Cast(global::Orleans.CodeGeneration.GrainFactoryBase.MakeKeyExtendedGrainReferenceInternal(typeof(DeviceInterfaces.IDeviceGrain), -354462699, primaryKey, keyExt,grainClassNamePrefix));
                        }

            public static DeviceInterfaces.IDeviceGrain Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return DeviceGrainReference.Cast(grainRef);
            }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
        [System.SerializableAttribute()]
        [global::Orleans.CodeGeneration.GrainReferenceAttribute("DeviceInterfaces.DeviceInterfaces.IDeviceGrain")]
        internal class DeviceGrainReference : global::Orleans.Runtime.GrainReference, global::Orleans.Runtime.IAddressable, DeviceInterfaces.IDeviceGrain
        {
            

            public static DeviceInterfaces.IDeviceGrain Cast(global::Orleans.Runtime.IAddressable grainRef)
            {
                
                return (DeviceInterfaces.IDeviceGrain) global::Orleans.Runtime.GrainReference.CastInternal(typeof(DeviceInterfaces.IDeviceGrain), (global::Orleans.Runtime.GrainReference gr) => { return new DeviceGrainReference(gr);}, grainRef, -354462699);
            }
            
            protected internal DeviceGrainReference(global::Orleans.Runtime.GrainReference reference) : 
                    base(reference)
            {
            }
            
            protected internal DeviceGrainReference(SerializationInfo info, StreamingContext context) : 
                    base(info, context)
            {
            }
            
            protected override int InterfaceId
            {
                get
                {
                    return -354462699;
                }
            }
            
            protected override string InterfaceName
            {
                get
                {
                    return "DeviceInterfaces.DeviceInterfaces.IDeviceGrain";
                }
            }
            
            [global::Orleans.CodeGeneration.CopierMethodAttribute()]
            public static object _Copier(object original)
            {
                DeviceGrainReference input = ((DeviceGrainReference)(original));
                return ((DeviceGrainReference)(global::Orleans.Runtime.GrainReference.CopyGrainReference(input)));
            }
            
            [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
            public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
            {
                DeviceGrainReference input = ((DeviceGrainReference)(original));
                global::Orleans.Runtime.GrainReference.SerializeGrainReference(input, stream, expected);
            }
            
            [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
            public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
            {
                return DeviceGrainReference.Cast(((global::Orleans.Runtime.GrainReference)(global::Orleans.Runtime.GrainReference.DeserializeGrainReference(expected, stream))));
            }
            
            public override bool IsCompatible(int interfaceId)
            {
                return (interfaceId == this.InterfaceId);
            }
            
            protected override string GetMethodName(int interfaceId, int methodId)
            {
                return DeviceGrainMethodInvoker.GetMethodName(interfaceId, methodId);
            }
            
            System.Threading.Tasks.Task DeviceInterfaces.IDeviceGrain.ProcessData(string @data)
            {

                return base.InvokeMethodAsync<object>(1920844431, new object[] {@data} );
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.0.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.MethodInvokerAttribute("DeviceInterfaces.DeviceInterfaces.IDeviceGrain", -354462699)]
    internal class DeviceGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        
        int global::Orleans.CodeGeneration.IGrainMethodInvoker.InterfaceId
        {
            get
            {
                return -354462699;
            }
        }
        
        global::System.Threading.Tasks.Task<object> global::Orleans.CodeGeneration.IGrainMethodInvoker.Invoke(global::Orleans.Runtime.IAddressable grain, int interfaceId, int methodId, object[] arguments)
        {

            try
            {                    if (grain == null) throw new System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case -354462699:  // IDeviceGrain
                        switch (methodId)
                        {
                            case 1920844431: 
                                return ((IDeviceGrain)grain).ProcessData((String)arguments[0]).ContinueWith(t => {if (t.Status == System.Threading.Tasks.TaskStatus.Faulted) throw t.Exception; return (object)null; });
                            default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                        }
                    default:
                        throw new System.InvalidCastException("interfaceId="+interfaceId);
                }
            }
            catch(Exception ex)
            {
                var t = new System.Threading.Tasks.TaskCompletionSource<object>();
                t.SetException(ex);
                return t.Task;
            }
        }
        
        public static string GetMethodName(int interfaceId, int methodId)
        {

            switch (interfaceId)
            {
                
                case -354462699:  // IDeviceGrain
                    switch (methodId)
                    {
                        case 1920844431:
                            return "ProcessData";
                    
                        default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                    }

                default:
                    throw new System.InvalidCastException("interfaceId="+interfaceId);
            }
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif
