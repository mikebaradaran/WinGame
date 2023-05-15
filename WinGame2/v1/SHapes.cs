using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinGameV1;


public class NoneGenericCollection
{
    private Object[] items = new Object[16];
    private int index = 0;

    public void add(Object item)
    {
        items[index] = item;
        index++;
    }
    public Object getItem(int index)
    {
        return items[index];
    }
}

public class GenericShapes<T>
{
    T[] items = new T[16];
    int index = 0;
    public void add(T item)
    {
        items[index] = item;
        index++;
    }
}
//--------------------------------------------------
class TestShapes
{
    NoneGenericCollection shapes = new NoneGenericCollection();
    public void test()
    {
        Ball b1 = new Ball(1, 1, 1, 1, 1, 1);
        shapes.add(b1);
        shapes.add(new Ball(2, 2, 2, 2, 2, 2));
        shapes.add(new Ball(3,3,3,3,3,3));
        Ball s = (Ball)shapes.getItem(1);
    }

}

