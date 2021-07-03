using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading;

namespace Algorithm.Code.Other
{
    public class Emit
    {
        public static Type EmitCreate()
        {
            var assemblyName = new AssemblyName("HolyFunc");
            var assembly = AssemblyBuilder.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Run);
            var module = assembly.DefineDynamicModule("Func");
            var classFunc = module.DefineType("Func1", TypeAttributes.Public);
            Type[] paras = new Type[] { typeof(string), typeof(string), typeof(string) };
            var method = classFunc.DefineMethod("SpecialS", MethodAttributes.Public, typeof(string), paras );
            var methodIL = method.GetILGenerator();

          

            var method1 = typeof(string).GetMethod("Concat", paras);
            // methodIL.EmitWriteLine(OpCodes.Pop);
            methodIL.DeclareLocal(typeof(string));

            //methodIL.Emit(OpCodes.Ldarg_0);
            //methodIL.Emit(OpCodes.Pop);
           //methodIL.Emit(OpCodes.Ret);

            methodIL.Emit(OpCodes.Ldarg_1);

            methodIL.Emit(OpCodes.Ldarg_2);
            methodIL.Emit(OpCodes.Ldarg_3);

            methodIL.Emit(OpCodes.Call, method1);
            methodIL.Emit(OpCodes.Ret);
            return classFunc.CreateType();
        }

        public static void Bulider()
        {
            var j = EmitCreate();
            var ins = Activator.CreateInstance(j);
            var m = j.GetMethod("SpecialS");
            var v = m.Invoke(ins, new object[] { "SpecialS1", "Func2","123" });
        }


    }
}
