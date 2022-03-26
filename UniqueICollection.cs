using System;
using System.Collections;
using System.Collections.Generic;
class UniqueCollection<TypeParameter> : ICollection<TypeParameter>
{
    public List<TypeParameter> items = new List<TypeParameter>();
    public int Count
    {
        get
        {
            return items.Count;
        }
    }
    public bool IsReadOnly
    {
        get
        {
            return false;
        }
    }
    //
    public void Add(TypeParameter number)
    {
        items.Add(number);
    }
    //
    public bool Remove(TypeParameter value)
    {
        return items.Remove(value);
    }
    //
    public bool Contains(TypeParameter number)
    {
        return (items.Contains(number));
    }
    //
    public void CopyTo(TypeParameter[] array, int arrayIndex)
    {
        if (items.Count > 0)
        {
            items.CopyTo(array, arrayIndex);
        }
    }
    //
    public void Enumerate()
    {
        if (items.Count > 0)
        {
            Console.WriteLine("The List member/s:");
            foreach (TypeParameter value in items)
                Console.Write(value + ", ");
        }
        else
            Console.WriteLine("The List is already empty");
    }
    //
    public void Clear()
    {
        items.Clear();
    }
    //
    public IEnumerator<TypeParameter> GetEnumerator()
    {
        foreach (TypeParameter item in items)
            yield return item;
    }
    //
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}