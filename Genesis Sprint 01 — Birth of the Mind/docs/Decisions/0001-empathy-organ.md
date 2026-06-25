# Decision 0001: Add Empathy as a Core Organ

## Status

Accepted

## Context

The original IphoxOS organism included:

- Eyes
- Brain
- Heart
- Director
- Hands
- Voice
- Memory

During design, the Creator clarified that IphoxOS should not simply understand stream events. It should try to perceive what the Creator and the Community may be feeling, while keeping those two emotional worlds separate.

This requirement is not fully covered by Brain or Heart.

Brain understands the world.
Heart represents IphoxOS' own internal mood.

A new organ is needed to interpret the emotional relationship between Creator and Community.

## Decision

Add Empathy as a core organ between Brain and Heart.

New flow:

```text
Eyes -> Brain -> Empathy -> Heart -> Director -> Hands / Voice
```

## Consequences

- Brain remains analytical.
- Heart remains internal to IphoxOS.
- Empathy becomes responsible for interpreting possible emotional states of Creator and Community.
- Director will use Empathy output before deciding whether to act, speak, wait, or stay silent.

## Principle

> Eyes see.  
> Brain understands.  
> Empathy feels with others.  
> Heart feels itself.  
> Director decides.  
> Hands act.
