using System;
using System.Collections.Generic;

namespace DataStructures
{
  public class HashMap
  {
    private LinkedList<KeyValuePair<string,string>>[] Map { get; set; }

    // This method sets the size of the map (amount of buckets)
    public HashMap(int size)
    {
      Map = new LinkedList<KeyValuePair<string, string>>[size];
    }

    //This method hashes the key value
    private int Hash(string key) {

      int hashValue = 0;

      char[] letters = key.ToCharArray();

      for(int i = 0; i < letters.Length; i++ )
      {
        hashValue += letters[i];
      }

      hashValue = (hashValue * 599) % Map.Length;

      return hashValue;
       
    }

    //This method calls the Hash method and uses it to assign key/value pairs
    public void Set(string key, string value)
    {
      
      int hashKey = Hash(key);

      if( Map[hashKey] == null )
      {
        Map[hashKey] = new LinkedList<KeyValuePair<string, string>>();
      }

      KeyValuePair<string, string> entry = new KeyValuePair<string, string>(key, value);
      Map[hashKey].Insert(entry);

    }

    // Calls the Hash() and uses it to check if values are in the map
    public bool Contains(string key)
    {

      int hashKey = Hash(key);

      if(Map[hashKey !] != null) 
      { 
        Node<KeyValuePair<string,string>> current = Map[hashKey].Head;

        while(current != null)
        { 
          if(current.Value.Key == key) { return true;  }
          current = current.Next;
	      }
      }

      return false;
    }

    // Gets the value from hash map
    public string Get(string key)
    {
      return "";
    }

    //Prints the values in the map
    public void Print()
    {
      for(int i = 0; i<Map.Length; i++)
      {
        Console.Write($"{i} -- ");
        if(Map[i] != null)
        {
          Node<KeyValuePair<string, string>> current = Map[i].Head;
          while(current != null)
          {
            Console.Write($"[{current.Value.Key}:{current.Value.Value}] => ");
            current = current.Next;
	        }
	      }
        Console.WriteLine();
      }
    }

  }
}