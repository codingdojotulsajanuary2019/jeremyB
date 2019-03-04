from django.db import models
from apps.login_app.models import User

class WishManager(models.Manager):
    def add_validator(self, postData):
        errors = {}
        print("Validation new wish")
        #Item Name Validations
        if len(postData['wish']) == 0:
            errors['wish'] = "Please enter a wish."
        else:
            if len(postData['wish']) < 3:
                errors['wish'] = "Wish must be longer than 3 characters."
        
        #Description Validations
        if len(postData['desc']) == 0:
            errors['desc'] = "Please enter a description."
        else:
            if len(postData['desc']) < 3:
                errors['desc'] = "Description must be longer than 3 characters."

        return errors

    def update_validator(self, postData):
        errors = {}
        print("Validation update wish")
        #Item Name Validations
        if len(postData['wish']) == 0:
            errors['wish'] = "Please enter a wish."
        else:
            if len(postData['wish']) < 3:
                errors['wish'] = "Wish must be longer than 3 characters."
        
        #Description Validations
        if len(postData['desc']) == 0:
            errors['desc'] = "Please enter a description."
        else:
            if len(postData['desc']) < 3:
                errors['desc'] = "Description must be longer than 3 characters."

        return errors

# Create your models here.
class Wish(models.Model):
    item = models.CharField(max_length=255)
    description = models.TextField()
    wished_by = models.ForeignKey(User, related_name="wisher")
    granted = models.DateField(null=True, blank=True)
    added = models.DateField(auto_now_add=True)
    likes = models.ManyToManyField(User, blank=True, related_name="liked_wish")
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
    objects = WishManager()

    def __repr__(self):
        return f"Wish: {self.item} {self.granted}"