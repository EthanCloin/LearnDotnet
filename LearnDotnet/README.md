# Overview
The goal of this project is to become more familiar with .NET(8.0).

I work in the .NET framework, but haven't used it for any personal projects.

## TreeView
A lot of the pages on my company site utilize a UI Component called TreeView. 

A TreeView expands each item it contains to display nested data without
overwhelming the user with the full level of detail all at once. 

I want to implement a similar pattern, using HTMX.
The Orders Page shows a prototype of a TreeView UI. The functionality and styling is very basic.

## Filtering
Another common pattern I see is a component above a certain
dataset which offers an interface to apply filters or searching.

### How to Implement
For the Orders page, I want to add a component that allows filtering
orders by Status. 

I'll include a wrapper element around a set of checkboxes.
The wrapper should be triggered whenever a box is checked or unchecked
to submit a GET request which gets an updated table.