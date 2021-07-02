class Solution:
    def getFolderNames(self, names: List[str]) -> List[str]:
        uniqueNames = set()
        orderedNames = []
        for name in names:
            if name in uniqueNames:
                i = 1
                currentName = f'{name}({i})'
                while currentName in uniqueNames:
                    i += 1
                    currentName = f'{name}({i})'
                uniqueNames.add(currentName)
                orderedNames.append(currentName)
            else:
                uniqueNames.add(name)
                orderedNames.append(name)
        return list(orderedNames)