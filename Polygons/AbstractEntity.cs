using System;
namespace Polygons
{
    public class AbstractEntity
    {
        private static int nextShapeId = 1;
        public int ShapeId { get; set; }

        public AbstractEntity()
        {
            ShapeId = nextShapeId++;
        }

        public int GetShapeId()
        {
            return ShapeId;
        }
    }
}
