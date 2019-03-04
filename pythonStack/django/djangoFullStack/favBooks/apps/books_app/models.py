from django.db import models
from apps.login_app.models import User

# Create your models here.


class BookManager(models.Manager):
    def add_validator(self, postData):
        errors = {}
        print("Validating Book")
        if len(postData['title']) < 2:
            errors['title'] = "Please enter a title"

        if len(postData['form_desc']) < 8:
            errors['desc'] = "Please enter a description"
        return errors


class Book(models.Model):
    title = models.CharField(max_length=255)
    description = models.TextField()
    uploaded_by = models.ForeignKey(User, related_name="uploader")
    user_like = models.ManyToManyField(User, blank=True, related_name="liked_books")
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
    objects = BookManager()
