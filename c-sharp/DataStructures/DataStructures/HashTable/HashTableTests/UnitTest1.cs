namespace HashTableTests;
using HashTables; // Assuming your HashMap class is in this namespace


public class UnitTest1
{

  [Fact]
  public void SettingKeyAndValueAddsToHashtable()
  {
    var hashMap = new HashMap(10);
    hashMap.Set("key1", "value1");
    Assert.Equal("value1", hashMap.Get("key1"));
  }


  [Fact]
  public void RetrieveByKeyReturnsStoredValue()
  {
    var hashMap = new HashMap(10);
    hashMap.Set("key1", "value1");
    hashMap.Set("key2", "value2");
    Assert.Equal("value1", hashMap.Get("key1"));
    Assert.Equal("value2", hashMap.Get("key2"));
  }


  [Fact]
  public void RetrieveNonExistentKeyReturnsNull()
  {
    var hashMap = new HashMap(10);
    Assert.Null(hashMap.Get("nonexistent"));
  }


  [Fact]
  public void GetUniqueKeysReturnsListOfKeys()
  {
    var hashMap = new HashMap(10);
    hashMap.Set("key1", "value1");
    hashMap.Set("key2", "value2");
    hashMap.Set("key3", "value3");
    var keys = hashMap.Keys();
    Assert.Contains("key1", keys);
    Assert.Contains("key2", keys);
    Assert.Contains("key3", keys);
    Assert.Equal(3, keys.Count);
  }


  [Fact]
  public void HandleCollisionWithinHashtable()
  {
    var hashMap = new HashMap(10);
    // These keys will have the same hash index
    hashMap.Set("key1", "value1");
    hashMap.Set("key11", "value11");
    Assert.Equal("value1", hashMap.Get("key1"));
    Assert.Equal("value11", hashMap.Get("key11"));
  }


  [Fact]
  public void RetrieveValueFromBucketWithCollision()
  {
    var hashMap = new HashMap(10);
    // These keys will have the same hash index
    hashMap.Set("key1", "value1");
    hashMap.Set("key11", "value11");
    Assert.Equal("value1", hashMap.Get("key1"));
    Assert.Equal("value11", hashMap.Get("key11"));
  }


  [Fact]
  public void HashKeyToInRangeValue()
  {
    var hashMap = new HashMap(10);
    int hashValue = hashMap.Hash("myKey");
    Assert.InRange(hashValue, 0, 9);
  }



  //CC- 31

  [Fact]
  public void RepeatedWord_ReturnFirstRepeatedWord()
  {
    var hashMap = new HashMap(100);
    var input = "Once upon a time, there was a brave princess who...";

    
    var result = hashMap.RepeatedWord(input);

    Assert.Equal("a", result);
  }

  [Fact]
  public void RepeatedWord_ReturnFirstRepeatedWord_WhenMultiple()
  {

    var hashMap = new HashMap(100);
    var input = "It was the best of times, it was the worst of times...";

  
    var result = hashMap.RepeatedWord(input);

    Assert.Equal("it", result);
  }





  ///CC-33
  ///


  [Fact]
  public void LeftJoin_Should_Return_Correct_Result()
  {
    Dictionary<string, string> synonyms = new Dictionary<string, string>
        {
            { "diligent", "employed" },
            { "fond", "enamored" },
            { "guide", "usher" },
            { "outfit", "garb" },
            { "wrath", "anger" }
        };

    Dictionary<string, string> antonyms = new Dictionary<string, string>
        {
            { "diligent", "idle" },
            { "fond", "averse" },
            { "guide", "follow" },
            { "flow", "jam" },
            { "wrath", "delight" }
        };

    List<List<string>> expected = new List<List<string>>
        {
            new List<string> { "diligent", "employed", "idle" },
            new List<string> { "fond", "enamored", "averse" },
            new List<string> { "guide", "usher", "follow" },
            new List<string> { "outfit", "garb", null },
            new List<string> { "wrath", "anger", "delight" }
        };


    List<List<string>> result = HashMap.LeftJoin(synonyms, antonyms);

    Assert.Equal(expected, result);
  }

}