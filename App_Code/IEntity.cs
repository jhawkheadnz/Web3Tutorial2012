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
   void Add(T item);
   void Get(ref List<T> item);
   void Get(ref T item, int id);
   void Update(T item, int id);
   void Delete(int id);
}