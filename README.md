# nearmap.com Technical Test
Welcome to [nearmap.com](nearmap.com) technical test. The purpose of this assignment is to test your familiarity with C#, distributed systems concepts, performance benchmarking and TDD.

## Background
The source code that you are given is a very simple imitation of a name/value store. `DatabaseStore` is the canonical data store that takes a while (50 ms) to store and retrieve data. `DistributedCacheStore` is an interface to a distributed cache that takes much less time to turn around - 5 ms.

## Assumptions 
* Data in the canonical store (database) never changes and can be cached forever.
* Data is never written to the canonical store (database), apart from during the startup.
* If `GetValue` method returns `null`, the request data item does not exist and will never exist.
* The solution should start with the distributed cache empty.
* Provided code can be modified at will.
* Any class in .NET Base Class Library can be used.

## Task
* The objective is to create a data retrival mechanism with lowest possible latency by implementing the `IDataSource` interface.
* The solution should have a better response time than that one of distributed cache for a frequently requested item.
* The solution should have unit tests for all new functionality.
* The user of the `IDataStore` interface must not have to deal with thread synchronisation.
* The database should be populated with the following data on startup:

    | key          | value         |
	--------------------------------
    | key0         | value0        |
	| key1         | value1        |
	| key2         | value2        |
	| key3         | value3        |
	| key4         | value4        |
	| key5         | value5        |
	| key6         | value6        |
	| key7         | value7        |
	| key8         | value8        |
	| key9         | value9        |

* The solution must have 10 threads each making 50 consecutive requests for a random key in the range (key0-key9). I.e. there would a total of 500 requests.
* The solution must print the managed ThreadId, requested key name, returned value, time to complete that request, similar to the following example:

   [1] Request 'key1', response 'value1', time: 50.05 ms
   [2] Request 'key2', response 'value2', time: 50.05 ms
  
## Submission instructions
* The whole Visual Studio solution must build with no errors.
* Submission must include all the source files and a compiled executable in a zip/rar file - submitted to your agent or nearmap contact.
* DO NOT send pull requests against this repository for two reasons:
  * We don't want executables checked into source control
  * We don't want other candidates to see your solution.