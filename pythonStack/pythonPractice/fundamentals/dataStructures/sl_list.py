from sl_node import Node

class SList:
    def __init__(self):
        self.head = None
    
    def add_to_front(self, val):
        new_node = Node(val)
        new_node.next = self.head
        self.head = new_node
        return self
    
    def print_values(self):
        runner = self.head
        while (runner != None):
            print(runner.value)
            runner = runner.next
        return self

    def add_to_back(self, val):
        if self.head == None:
            self.add_to_front(val)
            return self

        new_node = Node(val)
        runner = self.head
        while (runner.next != None):
            runner = runner.next
        runner.next = new_node
        return self

    def remove_from_front(self):
        if self.head == None:
            return self

        self.head = self.head.next
        return self

    def remove_from_back(self):
        if self.head == None:
            return self
        
        runner = self.head
        while (runner.next.next != None):
            runner = runner.next
        runner.next = None
        return self
    
    def remove_val(self, val):
        if self.head.value == val:
            self.head = self.head.next
            return self
        
        runner = self.head
        while (runner.next.value != val):
            runner = runner.next
        runner.next = runner.next.next
        return self

    def insert_at(self, val, n):
        if n == 0:
            new_node = Node(val)
            new_node.next = self.head
            self.head = new_node
            return self
        i = 1
        runner = self.head
        while i < n:
            runner = runner.next
            i +=1
        new_node = Node(val)
        new_node.next = runner.next
        runner.next = new_node
        return self

# insert_at(self, val, n) - insert a node with value val as the nth node in the list
# Consider the following cases:
    # n is 0
    # n is the length of the list
    # n is between 0 and the length of the list