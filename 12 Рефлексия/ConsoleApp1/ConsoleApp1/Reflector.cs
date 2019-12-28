using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace ConsoleApp1
{
    class Reflector
    {

        public void ClassInfoInText(string circl)
        {
            Type type = Type.GetType(circl);
            using (StreamWriter sw = new StreamWriter(@"C:\OOP\Text\text1.txt", false))
            {
                sw.WriteLine("Namespace.ClassName: " + circl);

                foreach (var constructors in type.GetConstructors())
                    sw.WriteLine(constructors.Name);

                foreach (var fields in type.GetFields())
                    sw.WriteLine(fields.Name);

                foreach (var methods in type.GetMethods())
                    sw.WriteLine(methods.Name);
            }
        }

        public void ClassMethods(string circl)
        {
            Type type = Type.GetType(circl);
            MethodInfo[] methods = type.GetMethods(BindingFlags.Public);
            foreach (MemberInfo k in type.GetMethods())
            {
                Console.WriteLine($"{k.DeclaringType} {k.MemberType} {k.Name}");
            }
        }

        public void InfoPol(string circl)
        {
            Type type = Type.GetType(circl);
            Console.WriteLine("Поля:");
            foreach (FieldInfo field in type.GetFields())
            {
                Console.WriteLine($"{field.FieldType} {field.Name}");
            }

            Console.WriteLine("Свойства:");
            foreach (PropertyInfo prop in type.GetProperties())
            {
                Console.WriteLine($"{prop.PropertyType} {prop.Name}");
            }

        }

        public void ClassInter(string circl)
        {
            Type type = Type.GetType(circl);
            Console.WriteLine("Реализованные интерфейсы:");
            foreach (Type i in type.GetInterfaces())
            {
                Console.WriteLine(i.Name);
            }
        }

        public void ClassName(string circl, string parametr)
        {
            Type type = Type.GetType(circl, false, true);
            Console.WriteLine();
            Console.WriteLine("Методы c заданными параметрами:");
            foreach (MethodInfo method in type.GetMethods())
            {
                string modificator = "";
                if (method.IsStatic)
                    modificator += "static ";
                if (method.IsVirtual)
                    modificator += "virtual";
                ParameterInfo[] parameters = method.GetParameters();
                for (int i = 0; i < parameters.Length; i++)
                {
                    if (parameters[i].ParameterType.Name == parametr)
                        Console.Write($"{modificator} {method.ReturnType.Name} {method.Name} ()");
                }

            }
        }

        public void ParamFile()
        {
            Console.WriteLine();
            Console.WriteLine("Метод с параметрами из файла:");
            FileStream file1 = new FileStream(@"C:\OOP\Text\param.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file1);
            string param = reader.ReadToEnd();
            reader.Close();
            string str = String.Concat(param);
            Console.WriteLine(str);
        }
    }
}
