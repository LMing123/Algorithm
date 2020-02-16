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
            var assemblyName = new AssemblyName("HolyFuck");
            var assembly = AssemblyBuilder.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Run);
            var module = assembly.DefineDynamicModule("Fuck");
            var classFuck = module.DefineType("Fuck1", TypeAttributes.Public);
            Type[] paras = new Type[] { typeof(string), typeof(string), typeof(string) };
            var method = classFuck.DefineMethod("Shit", MethodAttributes.Public, typeof(string), paras );
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
            return classFuck.CreateType();
        }

        public static void Bulider()
        {
            var j = EmitCreate();
            var ins = Activator.CreateInstance(j);
            var m = j.GetMethod("Shit");
            var v = m.Invoke(ins, new object[] { "shit1", "fuck2","123" });
        }


    }
}
