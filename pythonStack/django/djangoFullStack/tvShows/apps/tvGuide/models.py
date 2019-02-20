from django.db import models
from datetime import datetime

class ShowManager(models.Manager):
    def basic_validator(self, postData):
        errors = {}
        
        if len(postData['form_title']) < 2:
            errors["form_title"] = "Title should be at least 2 characters"
        if len(postData['form_network']) < 3:
            errors["form_network"] = "Network name should be at least 3 characters"
        if len(postData['form_desc']) != 0:
            if len(postData['form_desc']) < 10:
                errors["form_desc"] = "Description should be at least 10 characters"
        if len(postData['form_date']) == 0:
            errors["form_date"] = "Please enter a date"
        else:
            release_date = datetime.strptime(postData['form_date'],'%Y-%m-%d')
            if release_date > datetime.now():
                errors["form_date"] = "Date cannot be in the future"
        return errors

# Create your models here.
class Show(models.Model):
    title = models.CharField(max_length=255)
    network = models.CharField(max_length=45)
    release_date = models.DateField()
    description = models.TextField(null=True)
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
    objects = ShowManager()

    def __repr__(self):
        return f"Show: {self.title}"

