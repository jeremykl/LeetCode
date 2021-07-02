class MyHashMap:

    def __init__(self):
        """
        Initialize your data structure here.
        """
        self.hashmap = [[]]*1000
        self.hashsize = 1000

    def getHashKey(self, key):
        return key % self.hashsize

    def put(self, key: int, value: int) -> None:
        """
        value will always be non-negative.
        """
        position = self.getHashKey(key)
        for index, val in enumerate(self.hashmap[position]):
            if val[0] == key:
                val[1] = value
                return
        self.hashmap[position].append([key, value])

    def get(self, key: int) -> int:
        """
        Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key
        """
        position = self.getHashKey(key)
        for index, val in enumerate(self.hashmap[position]):
            if val[0] == key:
                return val[1]
        return -1

    def remove(self, key: int) -> None:
        """
        Removes the mapping of the specified value key if this map contains a mapping for the key
        """
        position = self.getHashKey(key)
        if self.hashmap[position]:
            for index, val in enumerate(self.hashmap[position]):
                if val[0] == key:
                    del self.hashmap[position][index]


# Your MyHashMap object will be instantiated and called as such:
# obj = MyHashMap()
# obj.put(key,value)
# param_2 = obj.get(key)
# obj.remove(key)
