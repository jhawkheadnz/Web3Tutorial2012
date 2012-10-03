using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Interface holding common methods inside the 
/// classes that implement it.
/// 
/// A generic "type"...
/// </summary>
public interface IEntity<T>
{
    public void Add(T item);
    public void Get(ref List<T> item);
    public void Get(ref T item, int id);
    public void Update(T item, int id);
    public void Delete(int id);
}