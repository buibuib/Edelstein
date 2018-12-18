using System.Drawing;
using Edelstein.Provider.Parser;
using PKG1;

namespace Edelstein.Provider.Templates.Field
{
    public class FieldReactorTemplate : ITemplate
    {
        public int ID { get; set; }

        public bool F { get; set; }
        public Point Position { get; set; }

        public static FieldReactorTemplate Parse(IDataProperty p)
        {
            var res = new FieldReactorTemplate
            {
                ID = p.Resolve<int>("id") ?? -1,
                F = p.Resolve<bool>("f") ?? false,
                Position = new Point(
                    p.Resolve<int>("x") ?? int.MinValue,
                    p.Resolve<int>("y") ?? int.MinValue
                )
            };

            return res;
        }
    }
}