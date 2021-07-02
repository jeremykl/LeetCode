# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, x):
#         self.val = x
#         self.next = None

class Solution:
  def addTwoNumbers(self, l1: 'ListNode', l2: 'ListNode') -> 'ListNode':
    ret = None
    offset = self.getLength(l1) - self.getLength(l2)
    RoundUp = [False]
    if offset >= 0:
      self.add(l1, l2, RoundUp, offset)
      ret = l1
    else:
      self.add(l2, l1, RoundUp, offset * -1)
      ret = l2
    if RoundUp[0]:
      ret = ListNode(1)
      if offset >= 0:
        ret.next = l1
      else:
        ret.next = l2
    return ret

  def getLength(self, l):
    if l.next != None:
      return 1 + self.getLength(l.next)
    else:
      return 1

  def add(self, l1: 'ListNode', l2: 'ListNode', roundUp, offset):
    currentValue = 0
    if offset != 0:
      currentValue = l1.val
      self.add(l1.next, l2, roundUp, offset - 1)
    elif l1.next != None:
      currentValue = l1.val + l2.val
      self.add(l1.next, l2.next, roundUp, offset)
    else:
      currentValue = l1.val + l2.val
    if roundUp[0]:
      currentValue += 1
    if(currentValue > 9):
      l1.val = currentValue % 10
      roundUp[0] = True
    else:
      l1.val = currentValue
      roundUp[0] = False
