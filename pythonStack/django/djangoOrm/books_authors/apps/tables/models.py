from django.db import models

# Create your models here.
class Author(models.Model):
    fname = models.CharField(max_length=45)
    lname = models.CharField(max_length=45)
    notes = models.TextField(null=True)
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now = True)

    def __repr__(self):
        return f"Author: {self.fname} {self.lname}"

class Book(models.Model):
    title = models.CharField(max_length=255)
    desc = models.TextField(null=True)
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now = True)
    authors = models.ManyToManyField(Author, related_name="books")

    def __repr__(self):
        return f"Book Title: {self.title}"

