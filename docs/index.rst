开源 LLM 应用框架
======================================================

.. image:: static/logos/Logo.png
   :height: 128px

.. image:: https://img.shields.io/discord/1106946823282761851?label=Discord
    :target: `discord`_

**使用 .NET 将 LLM 集成到您的应用程序中**

> 基于 LLM 的对话服务构建模块及最佳实践

*"对话即平台（CaaP）是未来，因此我们非常高兴为 .NET 开发者提供完整的工具包，使用 BotSharp 智能平台构建工具来创建 CaaP。它为您的机器人开放了尽可能多的学习能力，并精确控制人工智能处理管道中的每一步。"*

**BotSharp** 是为企业级 LLM 应用提供的一个开源 AI 框架。该项目涉及自然语言理解、计算机视觉以及音频处理技术，旨在推动智能机器人助手在面向商业系统中的开发和应用。开箱即用的机器学习算法使普通程序员能够以更快、更简单的方式开发人工智能应用。

BotSharp 使用 C# 开发，运行在 .NET 平台上，支持完整的跨平台功能。C# 是一种企业级编程语言，通常被广泛用于开发与信息管理系统相关的业务逻辑代码，更加适合企业开发者。BotSharp 直接采用了基于 C/C++ 接口的机器学习算法，跳过了 Python 接口的中间层。这充分发挥了强类型语言 C# 的优势，并且在系统范围内进行代码重构时更加便捷。

BotSharp 严格遵循组件化原则，将平台构建器中所需的每个部分进行解耦。因此，开发者可以选择不同的 UI/UX，或者使用另一种向量存储方式，甚至可以挑选更高级的算法来执行自然语言理解任务。所有模块都是基于统一接口进行模块化设计的。

索引和目录
==================
网站的主要文档划分为以下几个部分：

* :ref:`快速入门 <get-started>`
* :ref:`集成文档 <integration-docs>`
* :ref:`架构文档 <architecture-docs>`
* :ref:`搜索 <search>`

.. _get-started:

.. toctree::
   :maxdepth: 2
   :caption: 快速开始 BotSharp

   快速启动/概览
   快速启动/开始
   快速启动/安装

.. _agent-docs:

.. toctree::
   :maxdepth: 2
   :caption: 智能代理（Agent）

   代理/介绍
   代理/路由器
   代理/钩子

.. toctree::
   :maxdepth: 2
   :caption: 对话

   对话/介绍
   对话/状态
   对话/挂钩

.. _integration-docs:

.. toctree::
   :maxdepth: 2
   :caption: 互动渠道

   channels/intro
   channels/components
   channels/messenger
   channels/wechat

.. _knowledge-base:

.. toctree::
   :maxdepth: 2
   :caption: 知识库

   knowledge-base/text-embedding
   knowledge-base/vector-database
   knowledge-base/similarity-search
   knowledge-base/build-qa-bot

.. _llm:

.. toctree::
   :maxdepth: 2
   :caption: 提示工程

   llm/prompt
   llm/template
   llm/function
   llm/few-shot-learning
   llm/provider

.. _llamasharp:

.. toctree::
   :maxdepth: 2
   :caption: 本地 LLM 模型使用

   llama-sharp/config-llamasharp
   llama-sharp/use-llamasharp-in-ui

.. _architecture-docs:

.. toctree::
   :maxdepth: 2
   :caption: 架构

   architecture/authentication
   architecture/plugin
   architecture/hooks
   architecture/routing
   architecture/agent-utility
   architecture/logging
   architecture/data-persistence

如果您认为这个项目对您有帮助，请为我们项目加星，我们将不胜感激。

.. _discord: https://discord.gg/qRVm82fKTS
